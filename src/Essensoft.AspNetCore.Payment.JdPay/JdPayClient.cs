using Essensoft.AspNetCore.Payment.JdPay.Parser;
using Essensoft.AspNetCore.Payment.JdPay.Utility;
using Essensoft.AspNetCore.Security;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Essensoft.AspNetCore.Payment.JdPay
{
    public class JdPayClient : IJdPayClient
    {
        private const string VERSION = "version";
        private const string MERCHANT = "merchant";
        private const string SIGN = "sign";
        private const string ENCRYPT = "encrypt";
        private const string RESULT = "result";
        private const string BODY = "body";

        private ICipherParameters RSAPrivateParameters;
        private ICipherParameters RSAPublicParameters;
        private byte[] DesKey;

        public JdPayOptions Options { get; set; }

        public ILogger<JdPayClient> Logger { get; set; }

        protected internal HttpClientEx Client { get; set; }

        public JdPayClient(
            IOptions<JdPayOptions> optionsAccessor,
            ILogger<JdPayClient> logger)
        {
            Options = optionsAccessor?.Value ?? new JdPayOptions();
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

            RSAPrivateParameters = JdPaySignature.GetPrivateKeyParameters(Options.RsaPrivateKey);
            RSAPublicParameters = JdPaySignature.GetPublicKeyParameters(Options.RsaPublicKey);
            DesKey = Convert.FromBase64String(Options.DesKey);
        }

        public void SetTimeout(int timeout)
        {
            Client.Timeout = new TimeSpan(0, 0, 0, timeout);
        }

        public async Task<T> ExecuteAsync<T>(IJdPayRequest<T> request) where T : JdPayResponse
        {
            // 字典排序
            var sortedTxtParams = new JdPayDictionary(request.GetParameters());

            var content = BuildEncryptXml(request, sortedTxtParams);
            Logger.LogInformation(0, "Request:{content}", content);

            var rspContent = await Client.DoPostAsync(request.GetRequestUrl(), content);
            Logger.LogInformation(1, "Response:{content}", rspContent);

            var parser = new JdPayXmlParser<T>();
            var rsp = parser.Parse(JdPayUtility.FotmatXmlString(rspContent));
            if (!string.IsNullOrEmpty(rsp.Encrypt))
            {
                var encrypt = rsp.Encrypt;
                var base64EncryptStr = Encoding.UTF8.GetString(Convert.FromBase64String(encrypt));
                var reqBody = DES3.DecryptECB(DesKey, base64EncryptStr);
                Logger.LogInformation(2, "Encrypt Content:{body}", reqBody);

                var reqBodyDoc = new XmlDocument();
                reqBodyDoc.LoadXml(reqBody);

                var sign = JdPayUtility.GetValue(reqBodyDoc, "sign");
                var rootNode = reqBodyDoc.SelectSingleNode("jdpay");
                var signNode = rootNode.SelectSingleNode("sign");
                rootNode.RemoveChild(signNode);

                var reqBodyStr = JdPayUtility.ConvertXmlToString(reqBodyDoc);
                var xmlh = rsp.Body.Substring(0, rsp.Body.IndexOf("<jdpay>"));
                if (!string.IsNullOrEmpty(xmlh))
                {
                    reqBodyStr = reqBodyStr.Replace("<?xml version=\"1.0\" encoding=\"UTF-8\"?>", xmlh);
                }
                var sha256SourceSignString = SHA256.Compute(reqBodyStr);
                var decryptByte = JdPaySignature.Decrypt(sign, RSAPublicParameters);
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

        public Task<T> PageExecuteAsync<T>(IJdPayRequest<T> request, string reqMethod) where T : JdPayResponse
        {
            // 字典排序
            var sortedTxtParams = new JdPayDictionary(request.GetParameters());
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

        private string BuildEncryptXml<T>(IJdPayRequest<T> request, JdPayDictionary dic) where T : JdPayResponse
        {
            var xmldoc = JdPayUtility.SortedDictionary2AllXml(dic);
            var smlStr = JdPayUtility.ConvertXmlToString(xmldoc);
            var sha256SourceSignString = SHA256.Compute(smlStr);
            var encyptBytes = JdPaySignature.Encrypt(sha256SourceSignString, RSAPrivateParameters);
            var sign = Convert.ToBase64String(encyptBytes, Base64FormattingOptions.InsertLineBreaks);
            var data = smlStr.Replace("</jdpay>", "<sign>" + sign + "</sign></jdpay>");
            var encrypt = DES3.EncryptECB(DesKey, data);
            // 字典排序
            var reqdic = new JdPayDictionary
            {
                { VERSION, request.GetApiVersion() },
                { MERCHANT, Options.Merchant },
                { ENCRYPT, Convert.ToBase64String(Encoding.UTF8.GetBytes(encrypt)) }
            };

            return JdPayUtility.SortedDictionary2XmlStr(reqdic);
        }

        private JdPayDictionary BuildEncryptDic<T>(IJdPayRequest<T> request, IDictionary<string, string> dic) where T : JdPayResponse
        {
            var signDic = new JdPayDictionary(dic)
            {
                { VERSION, request.GetApiVersion() },
                { MERCHANT, Options.Merchant },
            };

            var signContent = JdPaySignature.GetSignContent(signDic);
            var sign = JdPaySignature.RSASign(signContent, RSAPrivateParameters);

            var encyptDic = new JdPayDictionary
            {
                { VERSION, request.GetApiVersion() },
                { MERCHANT, Options.Merchant },
                { SIGN, sign }
            };

            foreach (var item in dic)
            {
                if (!string.IsNullOrEmpty(item.Value))
                {
                    encyptDic.Add(item.Key, DES3.EncryptECB(DesKey, item.Value));
                }
            }
            return encyptDic;
        }

        private string BuildHtmlRequest(string url, JdPayDictionary dicPara)
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
