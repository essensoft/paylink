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

            var content = GetEncryptXmlContent(request, sortedTxtParams);
            Logger.LogInformation(0, "Request Content:{content}", content);

            var rspContent = await Client.DoPostAsync(request.GetRequestUrl(), content);
            Logger.LogInformation(1, "Response Content:{content}", rspContent);

            var formatStr = JdPayUtil.FotmatXmlString(rspContent);
            return DecryptResponseXmlContent<T>(formatStr);
        }

        public Task<T> PageExecuteAsync<T>(IJdPayRequest<T> request, string reqMethod) where T : JdPayResponse
        {
            // 字典排序
            var sortedTxtParams = new JdPayDictionary(request.GetParameters());
            var encyptParams = GetEncryptDicContent(request, sortedTxtParams);
            var rsp = Activator.CreateInstance<T>();
            rsp.Body = GetHtmlRequestContent(request.GetRequestUrl(), encyptParams, reqMethod);
            Logger.LogInformation(0, "Request Html:{body}", rsp.Body);
            return Task.FromResult(rsp);
        }

        private string GetEncryptXmlContent<T>(IJdPayRequest<T> request, JdPayDictionary dic) where T : JdPayResponse
        {
            var xmldoc = JdPayUtil.SortedDictionary2AllXml(dic);
            var smlStr = JdPayUtil.ConvertXmlToString(xmldoc);
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

            return JdPayUtil.SortedDictionary2XmlStr(reqdic);
        }

        private JdPayDictionary GetEncryptDicContent<T>(IJdPayRequest<T> request, IDictionary<string, string> dic) where T : JdPayResponse
        {
            var signDic = new JdPayDictionary(dic)
            {
                { VERSION, request.GetApiVersion() },
                { MERCHANT, Options.Merchant },
            };

            var sign = JdPaySignature.RSASign(signDic, RSAPrivateParameters);

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

        private T DecryptResponseXmlContent<T>(string xml) where T : JdPayResponse
        {
            if (string.IsNullOrEmpty(xml))
            {
                throw new Exception("Content is Empty!");
            }

            var entity = JdPayUtil.Deserialize<T>(xml);
            if (!string.IsNullOrEmpty(entity?.Encrypt))
            {
                var base64EncryptStr = Encoding.UTF8.GetString(Convert.FromBase64String(entity.Encrypt));
                var reqBody = DES3.DecryptECB(DesKey, base64EncryptStr);

                var reqBodyDoc = new XmlDocument();
                reqBodyDoc.LoadXml(reqBody);

                var inputSign = JdPayUtil.GetValue(reqBodyDoc, "sign");
                var jdpayRoot = reqBodyDoc.SelectSingleNode("jdpay");
                var signNode = jdpayRoot.SelectSingleNode("sign");
                jdpayRoot.RemoveChild(signNode);

                var reqBodyStr = JdPayUtil.ConvertXmlToString(reqBodyDoc);
                var xmlh = xml.Substring(0, xml.IndexOf("<jdpay>"));
                if (!string.IsNullOrEmpty(xmlh))
                {
                    reqBodyStr = reqBodyStr.Replace("<?xml version=\"1.0\" encoding=\"UTF-8\"?>", xmlh);
                }
                if (JdPaySignature.RSACheckContent(reqBodyStr, inputSign, RSAPublicParameters))
                {
                    entity = JdPayUtil.Deserialize<T>(reqBody);
                }
                else
                {
                    throw new Exception("sign check fail: check Sign and Data Fail!");
                }

                entity.Body = reqBody;
            }
            else
            {
                entity.Body = xml;
            }
            return entity;
        }

        private string GetHtmlRequestContent(string url, JdPayDictionary dicPara, string strMethod)
        {
            var sbHtml = new StringBuilder();
            sbHtml.Append("<form id='submit' name='submit' action='" + url + "' method='" + strMethod + "' style='display:none;'>");
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
