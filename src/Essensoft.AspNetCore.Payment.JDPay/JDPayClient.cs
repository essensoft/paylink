using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Essensoft.AspNetCore.Payment.JDPay.Parser;
using Essensoft.AspNetCore.Payment.JDPay.Request;
using Essensoft.AspNetCore.Payment.JDPay.Utility;
using Essensoft.AspNetCore.Payment.Security;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.JDPay
{
    public class JDPayClient : IJDPayClient
    {
        #region JDPayClient Constructors

        public JDPayClient(
            ILogger<JDPayClient> logger,
            IHttpClientFactory clientFactory,
            IOptionsSnapshot<JDPayOptions> optionsAccessor)
        {
            Logger = logger;
            ClientFactory = clientFactory;
            OptionsSnapshotAccessor = optionsAccessor;
        }

        #endregion

        public virtual ILogger Logger { get; set; }

        public virtual IHttpClientFactory ClientFactory { get; set; }

        public virtual IOptionsSnapshot<JDPayOptions> OptionsSnapshotAccessor { get; set; }

        #region IJDPayClient Members

        public async Task<T> ExecuteAsync<T>(IJDPayRequest<T> request) where T : JDPayResponse
        {
            return await ExecuteAsync(request, null);
        }

        public async Task<T> ExecuteAsync<T>(IJDPayRequest<T> request, string optionsName) where T : JDPayResponse
        {
            var options = string.IsNullOrEmpty(optionsName) ? OptionsSnapshotAccessor.Value : OptionsSnapshotAccessor.Get(optionsName);
            // 字典排序
            var sortedTxtParams = new JDPayDictionary(request.GetParameters());

            var content = BuildEncryptXml(request, sortedTxtParams, options);
            Logger?.LogTrace(0, "Request:{content}", content);

            using (var client = ClientFactory.CreateClient())
            {
                var body = await HttpClientUtility.DoPostAsync(client, request.GetRequestUrl(), content);
                Logger?.LogTrace(1, "Response:{content}", body);

                var parser = new JDPayXmlParser<T>();
                var rsp = parser.Parse(JDPayUtility.FotmatXmlString(body));
                if (!string.IsNullOrEmpty(rsp.Encrypt))
                {
                    var encrypt = rsp.Encrypt;
                    var base64EncryptStr = Encoding.UTF8.GetString(Convert.FromBase64String(encrypt));
                    var reqBody = JDPaySecurity.DecryptECB(base64EncryptStr, options.DesKeyBase64);
                    Logger?.LogTrace(2, "Encrypt Content:{body}", reqBody);

                    var reqBodyDoc = new XmlDocument { XmlResolver = null };
                    reqBodyDoc.LoadXml(reqBody);

                    var sign = JDPayUtility.GetValue(reqBodyDoc, "sign");
                    var rootNode = reqBodyDoc.SelectSingleNode("jdpay");
                    var signNode = rootNode.SelectSingleNode("sign");
                    rootNode.RemoveChild(signNode);

                    var reqBodyStr = JDPayUtility.ConvertXmlToString(reqBodyDoc);
                    var xmlh = rsp.Body.Substring(0, rsp.Body.IndexOf("<jdpay>"));
                    if (!string.IsNullOrEmpty(xmlh))
                    {
                        reqBodyStr = reqBodyStr.Replace("<?xml version=\"1.0\" encoding=\"UTF-8\"?>", xmlh);
                    }
                    var sha256SourceSignString = SHA256.Compute(reqBodyStr);
                    var decryptByte = RSA_ECB_PKCS1Padding.Decrypt(Convert.FromBase64String(sign), options.PublicKey);
                    var decryptStr = JDPaySecurity.BytesToString(decryptByte);
                    if (sha256SourceSignString == decryptStr)
                    {
                        rsp = parser.Parse(reqBody);
                        rsp.Encrypt = encrypt;
                    }
                    else
                    {
                        throw new Exception("sign check fail: check Sign and Data Fail!");
                    }
                }
                return rsp;
            }
        }

        #endregion

        #region IJDPayClient Members

        public Task<T> PageExecuteAsync<T>(IJDPayRequest<T> request) where T : JDPayResponse
        {
            return PageExecuteAsync(request, null);
        }

        public Task<T> PageExecuteAsync<T>(IJDPayRequest<T> request, string optionsName) where T : JDPayResponse
        {
            var options = string.IsNullOrEmpty(optionsName) ? OptionsSnapshotAccessor.Value : OptionsSnapshotAccessor.Get(optionsName);
            // 字典排序
            var sortedTxtParams = new JDPayDictionary(request.GetParameters());
            var encyptParams = BuildEncryptDic(request, sortedTxtParams, options);
            var rsp = Activator.CreateInstance<T>();

            //输出post表单
            rsp.Body = BuildHtmlRequest(request, encyptParams);
            return Task.FromResult(rsp);
        }

        #endregion

        #region IJDPayClient Members

        public async Task<T> ExecuteAsync<T>(IJDPayNPP10Request<T> request) where T : JDPayResponse
        {
            return await ExecuteAsync(request, null);
        }

        public async Task<T> ExecuteAsync<T>(IJDPayNPP10Request<T> request, string optionsName) where T : JDPayResponse
        {
            var options = string.IsNullOrEmpty(optionsName) ? OptionsSnapshotAccessor.Value : OptionsSnapshotAccessor.Get(optionsName);
            var sortedTxtParams = new JDPayDictionary(request.GetParameters())
            {
                { JDPayContants.CUSTOMER_NO, options.CustomerNo },
                { JDPayContants.SIGN_TYPE, options.SignType }
            };

            var isEncrypt = false;

            if (request is JDPayDefrayPayRequest)
            {
                isEncrypt = true;
            }

            var encryptDic = JDPaySecurity.EncryptData(options.PrivateCret, options.Password, options.PublicCert, sortedTxtParams, options.SingKey, options.EncryptType, isEncrypt);

            var content = JDPayUtility.BuildQuery(encryptDic);
            Logger?.LogTrace(0, "Request:{content}", content);

            using (var client = ClientFactory.CreateClient())
            {
                var body = await HttpClientUtility.DoPostAsync(client, request.GetRequestUrl(), content, "application/x-www-form-urlencoded");
                Logger?.LogTrace(1, "Response:{content}", body);

                var rsp = JsonConvert.DeserializeObject<T>(body);

                // 验签
                var dic = JsonConvert.DeserializeObject<JDPayDictionary>(body);
                if (!JDPaySecurity.VerifySign(dic, options.SingKey))
                {
                    throw new Exception("sign check fail: check Sign and Data Fail!");
                }

                rsp.Body = body;
                return rsp;
            }
        }

        #endregion

        #region Common Method

        private string BuildEncryptXml<T>(IJDPayRequest<T> request, JDPayDictionary dic, JDPayOptions options) where T : JDPayResponse
        {
            var xmldoc = JDPayUtility.SortedDictionary2AllXml(dic);
            var smlStr = JDPayUtility.ConvertXmlToString(xmldoc);
            var sha256SourceSignString = SHA256.Compute(smlStr);
            var encyptBytes = RSA_ECB_PKCS1Padding.Encrypt(Encoding.UTF8.GetBytes(sha256SourceSignString), options.PrivateKey);
            var sign = Convert.ToBase64String(encyptBytes, Base64FormattingOptions.InsertLineBreaks);
            var data = smlStr.Replace("</jdpay>", "<sign>" + sign + "</sign></jdpay>");
            var encrypt = JDPaySecurity.EncryptECB(data, options.DesKeyBase64);
            // 字典排序
            var reqdic = new JDPayDictionary
            {
                { JDPayContants.VERSION, request.GetApiVersion() },
                { JDPayContants.MERCHANT, options.Merchant },
                { JDPayContants.ENCRYPT, Convert.ToBase64String(Encoding.UTF8.GetBytes(encrypt)) }
            };

            return JDPayUtility.SortedDictionary2XmlStr(reqdic);
        }

        private JDPayDictionary BuildEncryptDic<T>(IJDPayRequest<T> request, IDictionary<string, string> parameters, JDPayOptions options) where T : JDPayResponse
        {
            var signDic = new JDPayDictionary(parameters)
            {
                { JDPayContants.VERSION, request.GetApiVersion() },
                { JDPayContants.MERCHANT, options.Merchant }
            };

            var signContent = JDPaySecurity.GetSignContent(signDic);
            var sign = JDPaySecurity.RSASign(signContent, options.PrivateKey);

            var encyptDic = new JDPayDictionary
            {
                { JDPayContants.VERSION, request.GetApiVersion() },
                { JDPayContants.MERCHANT, options.Merchant },
                { JDPayContants.SIGN, sign }
            };

            foreach (var iter in parameters)
            {
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    encyptDic.Add(iter.Key, JDPaySecurity.EncryptECB(iter.Value, options.DesKeyBase64));
                }
            }
            return encyptDic;
        }

        private string BuildHtmlRequest<T>(IJDPayRequest<T> request, IDictionary<string, string> parameters) where T : JDPayResponse
        {
            var sb = new StringBuilder();
            sb.Append("<form id='submit' name='submit' action='" + request.GetRequestUrl() + "' method='post' style='display:none;'>");
            foreach (var iter in parameters)
            {
                if (!string.IsNullOrEmpty(iter.Value))
                {
                    sb.Append("<input  name='" + iter.Key + "' value='" + iter.Value + "'/>");
                }
            }
            sb.Append("<input type='submit' style='display:none;'></form>");
            sb.Append("<script>document.forms['submit'].submit();</script>");
            return sb.ToString();
        }

        #endregion
    }
}
