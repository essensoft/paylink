using Essensoft.AspNetCore.Payment.JdPay.Parser;
using Essensoft.AspNetCore.Payment.JdPay.Utility;
using Essensoft.AspNetCore.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Crypto;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Essensoft.AspNetCore.Payment.JdPay
{
    public class JdPayNotifyClient
    {
        private ICipherParameters RSAPrivateParameters;
        private ICipherParameters RSAPublicParameters;
        private byte[] DesKey;

        public JdPayOptions Options { get; set; }

        public virtual ILogger<JdPayNotifyClient> Logger { get; set; }

        public JdPayNotifyClient(
            IOptions<JdPayOptions> optionsAccessor,
            ILogger<JdPayNotifyClient> logger)
        {
            Options = optionsAccessor?.Value ?? new JdPayOptions();
            Logger = logger;

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

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : JdPayNotifyResponse
        {
            if (request.ContentType == "application/x-www-form-urlencoded")
            {
                var dic = new JdPayDictionary();
                foreach (var item in request.Form)
                {
                    if (!string.IsNullOrEmpty(item.Value))
                    {
                        if (item.Key == "sign")
                        {
                            dic.Add(item.Key, item.Value);
                        }
                        else
                        {
                            dic.Add(item.Key, DES3.DecryptECB(DesKey, item.Value));
                        }
                    }
                }

                var query = HttpClientEx.BuildQuery(dic);
                Logger.LogInformation(1, "Request Content:{query}", query);

                var parser = new JdPayDictionaryParser<T>();
                var rsp = parser.Parse(dic);

                CheckNotifySign(dic, RSAPrivateParameters);
                return rsp;
            }
            else
            {
                var body = await new StreamReader(request.Body).ReadToEndAsync();
                Logger.LogInformation(1, "Request Content:{body}", body);

                var rsp = DecryptResponseXml<T>(JdPayUtil.FotmatXmlString(body));
                return rsp;
            }
        }

        private T DecryptResponseXml<T>(string xml) where T : JdPayNotifyResponse
        {
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
                var sha256SourceSignString = SHA256.Compute(reqBodyStr);
                var decryptByte = JdPaySignature.Decrypt(inputSign, RSAPublicParameters);
                var decryptStr = DES3.BytesToString(decryptByte);
                if (sha256SourceSignString == decryptStr)
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

        private void CheckNotifySign(JdPayDictionary content, object parameters)
        {
            if (content.Count == 0)
            {
                throw new Exception("sign check fail: Body is Empty!");
            }

            var sign = content["sign"];
            if (string.IsNullOrEmpty(sign))
            {
                throw new Exception("sign check fail: sign is Empty!");
            }

            if (!JdPaySignature.RSACheckContent(content, sign, RSAPublicParameters))
            {
                throw new Exception("sign check fail: check Sign and Data Fail");
            }
        }
    }
}
