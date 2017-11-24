using Essensoft.AspNetCore.JdPay.Utility;
using Essensoft.AspNetCore.Security;
using Microsoft.Extensions.Options;
using System;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Essensoft.AspNetCore.JdPay
{
    public class JdPayClient : IJdPayClient
    {
        private const string VERSION = "version";
        private const string MERCHANT = "merchant";
        private const string SIGN = "sign";
        private const string ENCRYPT = "encrypt";
        private const string RESULT = "result";
        private const string BODY = "body";

        public JdPayOptions Options { get; set; }

        protected internal HttpClientEx Client { get; set; }

        public JdPayClient(IOptions<JdPayOptions> optionsAccessor)
        {
            Options = optionsAccessor?.Value ?? new JdPayOptions();
            Client = new HttpClientEx();
        }

        public JdPayClient(string merchant, string rsaPublicKey, string rsaPrivateKey, string desKey)
            : this(null)
        {
            Options.Merchant = merchant;
            Options.RsaPublicKey = rsaPublicKey;
            Options.RsaPrivateKey = rsaPrivateKey;
            Options.DesKey = desKey;
        }

        public async Task<T> ExecuteAsync<T>(IJdPayRequest<T> request) where T : JdPayResponse
        {
            // 字典排序
            var sortedTxtParams = new JdPayDictionary(request.GetParameters());
            var xml = BuildEncryptXml(request, sortedTxtParams);
            var body = await Client.DoPostAsync(request.GetRequestUrl(), xml);
            return DecryptResponseXml<T>(JdPayUtil.FotmatXmlString(body));
        }

        private string BuildEncryptXml<T>(IJdPayRequest<T> request, JdPayDictionary dic) where T : JdPayResponse
        {
            var xmldoc = JdPayUtil.SortedDictionary2AllXml(dic);
            var smlStr = JdPayUtil.ConvertXmlToString(xmldoc);
            var sha256SourceSignString = Sha256.Encrypt(smlStr);
            var encyptBytes = JdPaySignature.Encrypt(sha256SourceSignString, Options.RsaPrivateKey);
            var sign = Convert.ToBase64String(encyptBytes, Base64FormattingOptions.InsertLineBreaks);
            var data = smlStr.Replace("</jdpay>", "<sign>" + sign + "</sign></jdpay>");
            var key = Convert.FromBase64String(Options.DesKey);
            var encrypt = Des3.Des3EncryptECB(key, data);
            // 字典排序
            var reqdic = new JdPayDictionary
            {
                { VERSION, request.GetApiVersion() },
                { MERCHANT, Options.Merchant },
                { ENCRYPT, Convert.ToBase64String(Encoding.UTF8.GetBytes(encrypt)) }
            };

            return JdPayUtil.SortedDictionary2XmlStr(reqdic);
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
