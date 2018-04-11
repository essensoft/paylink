using Essensoft.AspNetCore.Payment.JDPay.Parser;
using Essensoft.AspNetCore.Payment.JDPay.Utility;
using Essensoft.AspNetCore.Payment.Security;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Essensoft.AspNetCore.Payment.JDPay
{
    public class JDPayClient : IJDPayClient
    {
        private const string VERSION = "version";
        private const string MERCHANT = "merchant";
        private const string SIGN = "sign";
        private const string ENCRYPT = "encrypt";
        private const string RESULT = "result";
        private const string BODY = "body";

        private AsymmetricKeyParameter PrivateKey;
        private AsymmetricKeyParameter PublicKey;
        private byte[] DesKey;

        public JDPayOptions Options { get; set; }

        public ILogger<JDPayClient> Logger { get; set; }

        protected internal HttpClientEx Client { get; set; }

        public JDPayClient(
            IOptions<JDPayOptions> optionsAccessor,
            ILogger<JDPayClient> logger)
        {
            Options = optionsAccessor?.Value ?? new JDPayOptions();
            Logger = logger;
            Client = new HttpClientEx();

            if (string.IsNullOrEmpty(Options.Merchant))
            {
                throw new ArgumentNullException(nameof(Options.Merchant));
            }

            if (string.IsNullOrEmpty(Options.RsaPrivateKey))
            {
                throw new ArgumentNullException(nameof(Options.RsaPrivateKey));
            }

            if (string.IsNullOrEmpty(Options.RsaPublicKey))
            {
                throw new ArgumentNullException(nameof(Options.RsaPublicKey));
            }

            if (string.IsNullOrEmpty(Options.DesKey))
            {
                throw new ArgumentNullException(nameof(Options.DesKey));
            }

            PrivateKey = RSAUtilities.GetKeyParameterFormPrivateKey(Options.RsaPrivateKey);
            PublicKey = RSAUtilities.GetKeyParameterFormPublicKey(Options.RsaPublicKey);
            DesKey = Convert.FromBase64String(Options.DesKey);
        }

        public void SetTimeout(int timeout)
        {
            Client.Timeout = new TimeSpan(0, 0, 0, timeout);
        }

        public async Task<T> ExecuteAsync<T>(IJDPayRequest<T> request) where T : JDPayResponse
        {
            // 字典排序
            var sortedTxtParams = new JDPayDictionary(request.GetParameters());

            var content = BuildEncryptXml(request, sortedTxtParams);
            Logger.LogInformation(0, "Request:{content}", content);

            var rspContent = await Client.DoPostAsync(request.GetRequestUrl(), content);
            Logger.LogInformation(1, "Response:{content}", rspContent);

            var parser = new JDPayXmlParser<T>();
            var rsp = parser.Parse(JDPayUtility.FotmatXmlString(rspContent));
            if (!string.IsNullOrEmpty(rsp.Encrypt))
            {
                var encrypt = rsp.Encrypt;
                var base64EncryptStr = Encoding.UTF8.GetString(Convert.FromBase64String(encrypt));
                var reqBody = DES3.DecryptECB(base64EncryptStr, DesKey);
                Logger.LogInformation(2, "Encrypt Content:{body}", reqBody);

                var reqBodyDoc = new XmlDocument();
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
                var decryptByte = RSA_ECB_PKCS1Padding.Decrypt(Convert.FromBase64String(sign), PublicKey);
                var decryptStr = DES3.BytesToString(decryptByte);
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

        public Task<T> PageExecuteAsync<T>(IJDPayRequest<T> request, string reqMethod) where T : JDPayResponse
        {
            // 字典排序
            var sortedTxtParams = new JDPayDictionary(request.GetParameters());
            var encyptParams = BuildEncryptDic(request, sortedTxtParams);
            var rsp = Activator.CreateInstance<T>();

            var url = request.GetRequestUrl();
            if (reqMethod == "GET")
            {
                //拼接get请求的url
                var tmpUrl = url;
                if (encyptParams != null && encyptParams.Count > 0)
                {
                    if (tmpUrl.Contains("?"))
                    {
                        tmpUrl = tmpUrl + "&" + HttpClientEx.BuildQuery(encyptParams);
                    }
                    else
                    {
                        tmpUrl = tmpUrl + "?" + HttpClientEx.BuildQuery(encyptParams);
                    }
                }
                rsp.Body = tmpUrl;
            }
            else
            {
                //输出post表单
                rsp.Body = BuildHtmlRequest(url, encyptParams);
            }

            return Task.FromResult(rsp);
        }

        private string BuildEncryptXml<T>(IJDPayRequest<T> request, JDPayDictionary dic) where T : JDPayResponse
        {
            var xmldoc = JDPayUtility.SortedDictionary2AllXml(dic);
            var smlStr = JDPayUtility.ConvertXmlToString(xmldoc);
            var sha256SourceSignString = SHA256.Compute(smlStr);
            var encyptBytes = RSA_ECB_PKCS1Padding.Encrypt(Encoding.UTF8.GetBytes(sha256SourceSignString), PrivateKey);
            var sign = Convert.ToBase64String(encyptBytes, Base64FormattingOptions.InsertLineBreaks);
            var data = smlStr.Replace("</jdpay>", "<sign>" + sign + "</sign></jdpay>");
            var encrypt = DES3.EncryptECB(data, DesKey);
            // 字典排序
            var reqdic = new JDPayDictionary
            {
                { VERSION, request.GetApiVersion() },
                { MERCHANT, Options.Merchant },
                { ENCRYPT, Convert.ToBase64String(Encoding.UTF8.GetBytes(encrypt)) }
            };

            return JDPayUtility.SortedDictionary2XmlStr(reqdic);
        }

        private JDPayDictionary BuildEncryptDic<T>(IJDPayRequest<T> request, IDictionary<string, string> dic) where T : JDPayResponse
        {
            var signDic = new JDPayDictionary(dic)
            {
                { VERSION, request.GetApiVersion() },
                { MERCHANT, Options.Merchant },
            };

            var signContent = JDPaySecurity.GetSignContent(signDic);
            var sign = JDPaySecurity.RSASign(signContent, PrivateKey);

            var encyptDic = new JDPayDictionary
            {
                { VERSION, request.GetApiVersion() },
                { MERCHANT, Options.Merchant },
                { SIGN, sign }
            };

            foreach (var item in dic)
            {
                if (!string.IsNullOrEmpty(item.Value))
                {
                    encyptDic.Add(item.Key, DES3.EncryptECB(item.Value, DesKey));
                }
            }
            return encyptDic;
        }

        private string BuildHtmlRequest(string url, JDPayDictionary dicPara)
        {
            var sbHtml = new StringBuilder();
            sbHtml.Append("<form id='submit' name='submit' action='" + url + "' method='post' style='display:none;'>");
            foreach (var temp in dicPara)
            {
                sbHtml.Append("<input  name='" + temp.Key + "' value='" + temp.Value + "'/>");
            }
            sbHtml.Append("<input type='submit' style='display:none;'></form>");
            sbHtml.Append("<script>document.forms['submit'].submit();</script>");
            return sbHtml.ToString();
        }
    }
}
