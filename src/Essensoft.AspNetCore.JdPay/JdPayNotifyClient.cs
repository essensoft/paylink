using Essensoft.AspNetCore.JdPay.Parser;
using Essensoft.AspNetCore.JdPay.Utility;
using Essensoft.AspNetCore.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Crypto;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.Extensions.Logging;

namespace Essensoft.AspNetCore.JdPay
{
    public class JdPayNotifyClient
    {
        private ICipherParameters RSAPrivateParameters;
        private ICipherParameters RSAPublicParameters;

        public JdPayOptions Options { get; set; }

        public JdPayNotifyClient(JdPayOptions options)
        {
            Options = options;

            if (!string.IsNullOrEmpty(Options.RsaPrivateKey))
            {
                RSAPrivateParameters = JdPaySignature.GetPrivateKeyParameters(Options.RsaPrivateKey);
            }

            if (!string.IsNullOrEmpty(Options.RsaPublicKey))
            {
                RSAPublicParameters = JdPaySignature.GetPublicKeyParameters(Options.RsaPublicKey);
            }
        }

        public JdPayNotifyClient(IOptionsMonitor<JdPayOptions> optionsAccessor, ILogger<JdPayNotifyClient> logger)
            : this(optionsAccessor?.CurrentValue ?? new JdPayOptions())
        {
            optionsAccessor.OnChange(newOption =>
            {
                if (newOption.Equals(Options))
                    return;
                Options = newOption;
                logger.LogDebug($"{nameof(JdPayOptions)}配置已更新");
            });
        }

        public JdPayNotifyClient(string merchant, string publicKey, string desKey)
            : this(new JdPayOptions { Merchant = merchant, RsaPublicKey = publicKey, DesKey = desKey })
        {
        }

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : JdPayNotifyResponse
        {
            if (request.ContentType == "application/x-www-form-urlencoded")
            {
                var key = Convert.FromBase64String(Options.DesKey);
                var signDic = new JdPayDictionary();
                foreach (var item in request.Form)
                {
                    if (!string.IsNullOrEmpty(item.Value))
                    {
                        if (item.Key == "sign")
                        {
                            signDic.Add(item.Key, item.Value);
                        }
                        else
                        {
                            signDic.Add(item.Key, DES3.DecryptECB(key, item.Value));
                        }
                    }
                }

                var parser = new JdPayDictionaryParser<T>();
                var rsp = parser.Parse(signDic);

                CheckNotifySign(signDic, RSAPrivateParameters);
                return rsp;
            }
            else
            {
                var body = await new StreamReader(request.Body).ReadToEndAsync();
                var rsp = DecryptResponseXml<T>(JdPayUtil.FotmatXmlString(body));
                return rsp;
            }
        }

        private T DecryptResponseXml<T>(string xml) where T : JdPayNotifyResponse
        {
            var entity = JdPayUtil.Deserialize<T>(xml);
            if (!string.IsNullOrEmpty(entity?.Encrypt))
            {
                var key = Convert.FromBase64String(Options.DesKey);
                var base64EncryptStr = Encoding.UTF8.GetString(Convert.FromBase64String(entity.Encrypt));
                var reqBody = DES3.DecryptECB(key, base64EncryptStr);

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
