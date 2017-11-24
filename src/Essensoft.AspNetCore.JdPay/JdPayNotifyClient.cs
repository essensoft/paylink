using Essensoft.AspNetCore.JdPay.Utility;
using Essensoft.AspNetCore.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Essensoft.AspNetCore.JdPay
{
    public class JdPayNotifyClient
    {
        public JdPayOptions Options { get; set; }


        public JdPayNotifyClient(IOptions<JdPayOptions> optionsAccessor)
        {
            Options = optionsAccessor?.Value ?? new JdPayOptions();
        }

        public JdPayNotifyClient(string merchant, string rsaPublicKey, string desKey)
            : this(null)
        {
            Options.Merchant = merchant;
            Options.RsaPublicKey = rsaPublicKey;
            Options.DesKey = desKey;
        }

        public async Task<T> ExecuteAsync<T>(HttpRequest request) where T : JdPayResponse
        {
            var body = await new StreamReader(request.Body).ReadToEndAsync();
            var rsp = DecryptResponseXml<T>(JdPayUtil.FotmatXmlString(body));
            return rsp;
        }

        private T DecryptResponseXml<T>(string xml) where T : JdPayResponse
        {
            var entity = JdPayUtil.Deserialize<T>(typeof(T), xml);
            if (!string.IsNullOrEmpty(entity?.Encrypt))
            {
                var key = Convert.FromBase64String(Options.DesKey);
                var base64EncryptStr = Encoding.UTF8.GetString(Convert.FromBase64String(entity.Encrypt));
                var reqBody = Des3.Des3DecryptECB(key, base64EncryptStr);

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
                var sha256SourceSignString = Sha256.Encrypt(reqBodyStr);
                var decryptByte = JdPaySignature.Decrypt(inputSign, Options.RsaPublicKey);
                var decryptStr = Des3.BytesToString(decryptByte);
                if (sha256SourceSignString.Equals(decryptStr))
                {
                    entity = JdPayUtil.Deserialize<T>(typeof(T), reqBody);
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
            return (T)entity;
        }
    }
}
