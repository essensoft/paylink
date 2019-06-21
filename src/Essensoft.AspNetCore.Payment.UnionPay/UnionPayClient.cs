using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.UnionPay.Parser;
using Essensoft.AspNetCore.Payment.UnionPay.Request;
using Essensoft.AspNetCore.Payment.UnionPay.Utility;

namespace Essensoft.AspNetCore.Payment.UnionPay
{
    /// <summary>
    /// UnionPay 客户端。
    /// </summary>
    public class UnionPayClient : IUnionPayClient
    {
        private const string VERSION = "version";
        private const string ENCODING = "encoding";
        private const string SIGNMETHOD = "signMethod";
        private const string ACCESSTYPE = "accessType";
        private const string MERID = "merId";
        private const string ENCRYPTCERTID = "encryptCertId";
        private const string ACCNO = "accNo";

        private readonly IHttpClientFactory _httpClientFactory;

        #region UnionPayClient Constructors

        public UnionPayClient(
            IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        #endregion

        #region IUnionPayClient Members

        public async Task<T> ExecuteAsync<T>(IUnionPayRequest<T> request, UnionPayOptions options) where T : UnionPayResponse
        {
            var version = string.IsNullOrEmpty(request.GetApiVersion()) ? options.Version : request.GetApiVersion();

            var merId = options.MerId;
            if (options.TestMode && (request is UnionPayGatewayPayFileTransferRequest || request is UnionPayNoRedirectPayFileTransferRequest || request is UnionPayQrCodePayFileTransferRequest || request is UnionPayWapPayFileTransferRequest))
            {
                merId = "700000000000001";
            }

            var txtParams = new UnionPayDictionary(request.GetParameters())
            {
                { VERSION, version },
                { ENCODING, options.Encoding },
                { SIGNMETHOD, options.SignMethod },
                { ACCESSTYPE, options.AccessType },
                { MERID, merId }
            };

            if (request.HasEncryptCertId() && options.EncryptCertificate?.key != null)
            {
                if (txtParams.TryGetValue(ACCNO, out var accNo))
                {
                    if (!string.IsNullOrEmpty(accNo))
                    {
                        // 对敏感信息加密
                        txtParams[ACCNO] = UnionPaySignature.EncryptData(accNo, options.EncryptCertificate.key);

                        txtParams.Add(ENCRYPTCERTID, options.EncryptCertificate.certId);
                    }
                }
            }

            UnionPaySignature.Sign(txtParams, options.SignCertificate.certId, options.SignCertificate.key, options.SecureKey);

            var query = UnionPayUtility.BuildQuery(txtParams);

            using (var client = _httpClientFactory.CreateClient(nameof(UnionPayClient)))
            {
                var body = await client.DoPostAsync(request.GetRequestUrl(options.TestMode), query);

                var dictionary = ParseQueryString(body);

                var ifValidateCNName = !options.TestMode;
                if (!UnionPaySignature.Validate(dictionary, options.RootCertificate.cert, options.MiddleCertificate.cert, options.SecureKey, ifValidateCNName))
                {
                    throw new UnionPayException("sign check fail: check Sign and Data Fail!");
                }

                var parser = new UnionPayDictionaryParser<T>();
                var rsp = parser.Parse(dictionary);
                rsp.Body = body;
                return rsp;
            }
        }

        #endregion

        #region IUnionPayClient Members

        public Task<T> PageExecuteAsync<T>(IUnionPayRequest<T> request, UnionPayOptions options) where T : UnionPayResponse
        {
            var version = string.IsNullOrEmpty(request.GetApiVersion()) ? options.Version : request.GetApiVersion();
            var merId = options.MerId;

            if (options.TestMode && (request is UnionPayGatewayPayFileTransferRequest || request is UnionPayNoRedirectPayFileTransferRequest || request is UnionPayQrCodePayFileTransferRequest || request is UnionPayWapPayFileTransferRequest))
            {
                merId = "700000000000001";
            }

            var txtParams = new UnionPayDictionary(request.GetParameters())
            {
                { VERSION, version },
                { ENCODING, options.Encoding },
                { SIGNMETHOD, options.SignMethod },
                { ACCESSTYPE, options.AccessType },
                { MERID, merId }
            };

            if (request.HasEncryptCertId() && options.EncryptCertificate?.key != null)
            {
                if (txtParams.TryGetValue(ACCNO, out var accNo))
                {
                    if (!string.IsNullOrEmpty(accNo))
                    {
                        // 对敏感信息加密
                        txtParams[ACCNO] = UnionPaySignature.EncryptData(accNo, options.EncryptCertificate.key);

                        txtParams.Add(ENCRYPTCERTID, options.EncryptCertificate.certId);
                    }
                }
            }

            UnionPaySignature.Sign(txtParams, options.SignCertificate.certId, options.SignCertificate.key, options.SecureKey);

            var rsp = Activator.CreateInstance<T>();

            var url = request.GetRequestUrl(options.TestMode);

            //输出post表单
            rsp.Body = BuildHtmlRequest(url, txtParams);
            return Task.FromResult(rsp);
        }

        #endregion

        #region Common Method

        private string BuildHtmlRequest(string url, UnionPayDictionary dictionary)
        {
            var sbHtml = new StringBuilder();
            sbHtml.Append("<form id='submit' name='submit' action='" + url + "' method='post' style='display:none;'>");
            foreach (var iter in dictionary)
            {
                sbHtml.Append("<input  name='" + iter.Key + "' value='" + iter.Value + "'/>");
            }
            sbHtml.Append("<input type='submit' style='display:none;'></form>");
            sbHtml.Append("<script>document.forms['submit'].submit();</script>");
            return sbHtml.ToString();
        }

        private static Dictionary<string, string> ParseQueryString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            var Dictionary = new Dictionary<string, string>();
            var key = string.Empty;
            var isKey = true;
            var isOpen = false; // 值里有嵌套
            var openName = '\0'; // 关闭符
            var sb = new StringBuilder();

            for (var i = 0; i < str.Length; i++) // 遍历整个带解析的字符串
            {
                var curChar = str[i];// 取当前字符
                if (isOpen)
                {
                    if (curChar == openName)
                    {
                        isOpen = false;
                    }
                    sb.Append(curChar);
                }
                else if (curChar == '{')
                {
                    isOpen = true;
                    openName = '}';
                    sb.Append(curChar);
                }
                else if (curChar == '[')
                {
                    isOpen = true;
                    openName = ']';
                    sb.Append(curChar);
                }
                else if (isKey && curChar == '=') // 如果当前生成的是key且如果读取到=分隔符
                {
                    key = sb.ToString();
                    sb = new StringBuilder();
                    isKey = false;
                }
                else if (curChar == '&' && !isOpen) // 如果读取到&分割符
                {
                    PutKeyValueToDictionary(sb, isKey, key, Dictionary);
                    sb = new StringBuilder();
                    isKey = true;
                }
                else
                {
                    sb.Append(curChar);
                }
            }
            if (key != null)
            {
                PutKeyValueToDictionary(sb, isKey, key, Dictionary);
            }

            return Dictionary;
        }

        private static void PutKeyValueToDictionary(StringBuilder temp, bool isKey, string key, Dictionary<string, string> dictionary)
        {
            if (isKey)
            {
                key = temp.ToString();
                if (key.Length == 0)
                {
                    throw new UnionPayException("QueryString format illegal");
                }
                dictionary[key] = string.Empty;
            }
            else
            {
                if (key.Length == 0)
                {
                    throw new UnionPayException("QueryString format illegal");
                }
                dictionary[key] = temp.ToString();
            }
        }

        #endregion
    }
}
