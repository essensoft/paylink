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
            if (request.HasFormContentType)
            {
                var parameters = await GetParametersAsync(request);

                var query = HttpClientEx.BuildQuery(parameters);
                Logger.LogInformation(0, "Request:{query}", query);

                var parser = new JdPayDictionaryParser<T>();
                var rsp = parser.Parse(parameters);

                CheckNotifySign(rsp.Parameters, RSAPrivateParameters);
                return rsp;
            }
            else if(request.HasTextXmlContentType())
            {
                var body = await new StreamReader(request.Body).ReadToEndAsync();
                Logger.LogInformation(0, "Request:{body}", body);

                var parser = new JdPayXmlParser<T>();
                var rsp = parser.Parse(JdPayUtility.FotmatXmlString(body));
                if (!string.IsNullOrEmpty(rsp.Encrypt))
                {
                    var encrypt = rsp.Encrypt;
                    var base64EncryptStr = Encoding.UTF8.GetString(Convert.FromBase64String(encrypt));
                    var reqBody = DES3.DecryptECB(DesKey, base64EncryptStr);
                    Logger.LogInformation(1, "Encrypt Content:{body}", reqBody);

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
            else
            {
                throw new Exception("sign check fail: check Sign and Data Fail!");
            }
        }

        private async Task<JdPayDictionary> GetParametersAsync(HttpRequest request)
        {
            var parameters = new JdPayDictionary();
            var form = await request.ReadFormAsync();
            foreach (var item in form)
            {
                if (item.Key != "sign")
                {
                    parameters.Add(item.Key, DES3.DecryptECB(DesKey, item.Value));
                }
                else
                {
                    parameters.Add(item.Key, item.Value);
                }
            }
            return parameters;
        }

        private void CheckNotifySign(JdPayDictionary para, object parameters)
        {
            if (para.Count == 0)
            {
                throw new Exception("sign check fail: para is Empty!");
            }

            if (!para.TryGetValue("sign", out var sign))
            {
                throw new Exception("sign check fail: sign is Empty!");
            }

            var signContent = JdPaySignature.GetSignContent(para);
            if (!JdPaySignature.RSACheckContent(signContent, sign, RSAPublicParameters))
            {
                throw new Exception("sign check fail: check Sign and Data Fail");
            }
        }
    }
}
