using Essensoft.AspNetCore.JdPay.Utility;
using Essensoft.AspNetCore.Security;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
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

        private ICipherParameters RSAPrivateParameters;
        private ICipherParameters RSAPublicParameters;

        public JdPayOptions Options { get; set; }

        protected internal HttpClientEx Client { get; set; }

        public JdPayClient(JdPayOptions options)
        {
            Options = options;
            Client = new HttpClientEx();

            if (!string.IsNullOrEmpty(Options.RsaPrivateKey))
            {
                RSAPrivateParameters = JdPaySignature.GetPrivateKeyParameters(Options.RsaPrivateKey);
            }

            if (!string.IsNullOrEmpty(Options.RsaPublicKey))
            {
                RSAPublicParameters = JdPaySignature.GetPublicKeyParameters(Options.RsaPublicKey);
            }
        }

        public JdPayClient(IOptions<JdPayOptions> optionsAccessor)
            : this(optionsAccessor?.Value ?? new JdPayOptions())
        {
        }


        public JdPayClient(string merchant, string publicKey, string privateKey, string desKey)
            : this(new JdPayOptions { Merchant = merchant, RsaPublicKey = publicKey, RsaPrivateKey = privateKey, DesKey = desKey })
        {
        }

        public async Task<T> ExecuteAsync<T>(IJdPayRequest<T> request) where T : JdPayResponse
        {
            // 字典排序
            var sortedTxtParams = new JdPayDictionary(request.GetParameters());

            var reqContent = GetEncryptXmlContent(request, sortedTxtParams);

            var rspContent = await Client.DoPostAsync(request.GetRequestUrl(), reqContent);
            if(string.IsNullOrEmpty(rspContent))
            {
                throw new Exception("rspContent is Empty!");
            }

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
            var key = Convert.FromBase64String(Options.DesKey);
            var encrypt = DES3.EncryptECB(key, data);
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
            var key = Convert.FromBase64String(Options.DesKey);
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
                    encyptDic.Add(item.Key, DES3.EncryptECB(key, item.Value));
                }
            }
            return encyptDic;
        }

        private T DecryptResponseXmlContent<T>(string xml) where T : JdPayResponse
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
