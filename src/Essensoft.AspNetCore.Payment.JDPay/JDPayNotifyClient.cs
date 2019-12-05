#if NETCOREAPP3_1

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

namespace Essensoft.AspNetCore.Payment.JDPay
{
    /// <summary>
    /// JDPay 通知解析客户端。
    /// </summary>
    public class JDPayNotifyClient : IJDPayNotifyClient
    {
        #region JDPayNotifyClient Constructors

        public JDPayNotifyClient()
        {
        }

        #endregion

        #region IJDPayNotifyClient Members

        public async Task<T> ExecuteAsync<T>(HttpRequest request, JDPayOptions options) where T : JDPayNotify
        {
            if (request.HasFormContentType || request.Method == "GET")
            {
                var rspInstance = Activator.CreateInstance<T>();

                var parameters = GetParameters(request, options, !(rspInstance is JDPayDefrayPayNotify));

                var parser = new JDPayDictionaryParser<T>();
                var rsp = parser.Parse(parameters);

                if (rsp is JDPayDefrayPayNotify)
                {
                    CheckNotifyDefrayPaySign(rsp.Parameters, options);
                }
                else
                {
                    CheckNotifySign(rsp.Parameters, options);
                }

                return rsp;
            }

            if (request.HasTextXmlContentType())
            {
                var body = await new StreamReader(request.Body).ReadToEndAsync();
                var parser = new JDPayXmlParser<T>();
                var rsp = parser.Parse(JDPayUtility.FotmatXmlString(body));
                if (!string.IsNullOrEmpty(rsp.Encrypt))
                {
                    var encrypt = rsp.Encrypt;
                    var base64EncryptStr = Encoding.UTF8.GetString(Convert.FromBase64String(encrypt));
                    var reqBody = JDPaySecurity.DecryptECB(base64EncryptStr, options.DesKeyBase64);

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
                    var decryptByte = RSA_ECB_PKCS1Padding.Decrypt(Convert.FromBase64String(sign), options.PublicKey);
                    var decryptStr = JDPaySecurity.BytesToString(decryptByte);
                    if (sha256SourceSignString == decryptStr)
                    {
                        rsp = parser.Parse(reqBody);
                        rsp.Encrypt = encrypt;
                        return rsp;
                    }

                    throw new JDPayException("sign check fail: check Sign and Data Fail!");
                }

                throw new JDPayException("encrypt is Empty!");
            }

            throw new JDPayException("content type is not supported!");
        }

        #endregion

        #region Common Method

        private JDPayDictionary GetParameters(HttpRequest request, JDPayOptions options, bool isDecrypt = true)
        {
            var dictionary = new JDPayDictionary();

            if (request.Method == "POST")
            {
                foreach (var iter in request.Form)
                {
                    if (!string.IsNullOrEmpty(iter.Value))
                    {
                        var value = iter.Value.ToString();
                        if (isDecrypt)
                        {
                            value = iter.Key == JDPayContants.SIGN ? iter.Value.ToString() : JDPaySecurity.DecryptECB(iter.Value, options.DesKeyBase64);
                        }
                        dictionary.Add(iter.Key, value);
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
                            value = iter.Key == JDPayContants.SIGN ? iter.Value.ToString() : JDPaySecurity.DecryptECB(iter.Value, options.DesKeyBase64);
                        }
                        dictionary.Add(iter.Key, value);
                    }
                }
            }
            return dictionary;
        }

        private void CheckNotifySign(JDPayDictionary dictionary, JDPayOptions options)
        {
            if (dictionary.Count == 0)
            {
                throw new JDPayException("sign check fail: dictionary is Empty!");
            }

            if (!dictionary.TryGetValue(JDPayContants.SIGN, out var sign))
            {
                throw new JDPayException("sign check fail: sign is Empty!");
            }

            var signContent = JDPaySecurity.GetSignContent(dictionary);
            if (!JDPaySecurity.RSACheckContent(signContent, sign, options.PublicKey))
            {
                throw new JDPayException("sign check fail: check Sign and Data Fail");
            }
        }

        private void CheckNotifyDefrayPaySign(JDPayDictionary dictionary, JDPayOptions options)
        {
            if (dictionary.Count == 0)
            {
                throw new JDPayException("sign check fail: dictionary is Empty!");
            }

            if (!dictionary.TryGetValue(JDPayContants.SIGN_DATA, out var sign_data))
            {
                throw new JDPayException("sign check fail: sign is Empty!");
            }

            if (!JDPaySecurity.VerifySign(dictionary, options.SingKey))
            {
                throw new JDPayException("sign check fail: check Sign and Data Fail!");
            }
        }

        #endregion
    }
}

#endif
