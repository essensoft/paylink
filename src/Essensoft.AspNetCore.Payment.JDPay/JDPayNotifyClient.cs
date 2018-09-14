using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Essensoft.AspNetCore.Payment.JDPay.Notify;
using Essensoft.AspNetCore.Payment.JDPay.Parser;
using Essensoft.AspNetCore.Payment.JDPay.Utility;
using Essensoft.AspNetCore.Payment.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Crypto;

namespace Essensoft.AspNetCore.Payment.JDPay
{
    public class JDPayNotifyClient : IJDPayNotifyClient
    {
        private readonly AsymmetricKeyParameter PrivateKey;
        private readonly AsymmetricKeyParameter PublicKey;
        private readonly byte[] DesKey;

        public virtual ILogger Logger { get; set; }

        public JDPayOptions Options { get; }

        #region JDPayNotifyClient Constructors

        public JDPayNotifyClient(
            ILogger<JDPayNotifyClient> logger,
            IOptions<JDPayOptions> optionsAccessor)
        {
            Logger = logger;
            Options = optionsAccessor.Value;

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

        #endregion

        #region IJDPayNotifyClient Members

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : JDPayNotifyResponse
        {
            if (request.HasFormContentType || request.Method == "GET")
            {
                var rspInstance = Activator.CreateInstance<T>();

                var parameters = GetParameters(request, !(rspInstance is JDPayDefrayPayNotifyResponse));

                var query = JDPayUtility.BuildQuery(parameters);
                Logger?.LogTrace(0, "Request:{query}", query);

                var parser = new JDPayDictionaryParser<T>();
                var rsp = parser.Parse(parameters);

                if (rsp is JDPayDefrayPayNotifyResponse)
                {
                    CheckNotifyDefrayPaySign(rsp.Parameters);
                }
                else
                {
                    CheckNotifySign(rsp.Parameters);
                }

                return rsp;
            }
            else if (request.HasTextXmlContentType())
            {
                var body = await new StreamReader(request.Body).ReadToEndAsync();
                Logger?.LogTrace(0, "Request:{body}", body);

                var parser = new JDPayXmlParser<T>();
                var rsp = parser.Parse(JDPayUtility.FotmatXmlString(body));
                if (!string.IsNullOrEmpty(rsp.Encrypt))
                {
                    var encrypt = rsp.Encrypt;
                    var base64EncryptStr = Encoding.UTF8.GetString(Convert.FromBase64String(encrypt));
                    var reqBody = JDPaySecurity.DecryptECB(base64EncryptStr, DesKey);
                    Logger?.LogTrace(1, "Encrypt Content:{reqBody}", reqBody);

                    var reqBodyDoc = new XmlDocument() { XmlResolver = null };
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
                    var decryptStr = JDPaySecurity.BytesToString(decryptByte);
                    if (sha256SourceSignString == decryptStr)
                    {
                        rsp = parser.Parse(reqBody);
                        rsp.Encrypt = encrypt;
                        return rsp;
                    }
                    else
                    {
                        throw new Exception("sign check fail: check Sign and Data Fail!");
                    }
                }
                else
                {
                    throw new Exception("encrypt is Empty!");
                }
            }
            else
            {
                throw new Exception("content type is not supported!");
            }
        }

        #endregion

        #region Common Method

        private JDPayDictionary GetParameters(HttpRequest request, bool isDecrypt = true)
        {
            var parameters = new JDPayDictionary();

            if (request.Method == "POST")
            {
                foreach (var iter in request.Form)
                {
                    if (!string.IsNullOrEmpty(iter.Value))
                    {
                        var value = iter.Value.ToString();
                        if (isDecrypt)
                        {
                            value = iter.Key == JDPayContants.SIGN ? iter.Value.ToString() : JDPaySecurity.DecryptECB(iter.Value, DesKey);
                        }
                        parameters.Add(iter.Key, value);
                    }
                }
            }
            else
            {
                foreach (var iter in request.Query)
                {
                    if (!string.IsNullOrEmpty(iter.Value))
                    {
                        var value = iter.Value.ToString();
                        if (isDecrypt)
                        {
                            value = iter.Key == JDPayContants.SIGN ? iter.Value.ToString() : JDPaySecurity.DecryptECB(iter.Value, DesKey);
                        }
                        parameters.Add(iter.Key, value);
                    }
                }
            }
            return parameters;
        }

        private void CheckNotifySign(JDPayDictionary parameters)
        {
            if (parameters.Count == 0)
            {
                throw new Exception("sign check fail: parameters is Empty!");
            }

            if (!parameters.TryGetValue(JDPayContants.SIGN, out var sign))
            {
                throw new Exception("sign check fail: sign is Empty!");
            }

            var signContent = JDPaySecurity.GetSignContent(parameters);
            if (!JDPaySecurity.RSACheckContent(signContent, sign, PublicKey))
            {
                throw new Exception("sign check fail: check Sign and Data Fail");
            }
        }

        private void CheckNotifyDefrayPaySign(JDPayDictionary parameters)
        {
            if (parameters.Count == 0)
            {
                throw new Exception("sign check fail: parameters is Empty!");
            }

            if (!parameters.TryGetValue(JDPayContants.SIGN_DATA, out var sign_data))
            {
                throw new Exception("sign check fail: sign is Empty!");
            }

            if (!JDPaySecurity.VerifySign(parameters, Options.SingKey))
            {
                throw new Exception("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion
    }
}
