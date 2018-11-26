using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.UnionPay.Parser;
using Essensoft.AspNetCore.Payment.UnionPay.Request;
using Essensoft.AspNetCore.Payment.UnionPay.Utility;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Essensoft.AspNetCore.Payment.UnionPay
{
    public class UnionPayClient : IUnionPayClient
    {
        private const string VERSION = "version";
        private const string ENCODING = "encoding";
        private const string SIGNMETHOD = "signMethod";
        private const string ACCESSTYPE = "accessType";
        private const string MERID = "merId";
        private const string ENCRYPTCERTID = "encryptCertId";

        #region UnionPayClient Constructors

        public UnionPayClient(
            ILogger<UnionPayClient> logger,
            IHttpClientFactory clientFactory,
            IOptionsSnapshot<UnionPayOptions> optionsAccessor)
        {
            Logger = logger;
            ClientFactory = clientFactory;
            OptionsSnapshotAccessor = optionsAccessor;
        }

        #endregion

        public virtual ILogger Logger { get; set; }

        public virtual IHttpClientFactory ClientFactory { get; set; }

        public virtual IOptionsSnapshot<UnionPayOptions> OptionsSnapshotAccessor { get; set; }

        #region IUnionPayClient Members

        public async Task<T> ExecuteAsync<T>(IUnionPayRequest<T> request) where T : UnionPayResponse
        {
            return await ExecuteAsync(request, null);
        }

        public async Task<T> ExecuteAsync<T>(IUnionPayRequest<T> request, string optionsName) where T : UnionPayResponse
        {
            var options = string.IsNullOrEmpty(optionsName) ? OptionsSnapshotAccessor.Value : OptionsSnapshotAccessor.Get(optionsName);
            var version = string.IsNullOrEmpty(request.GetApiVersion()) ? options.Version : request.GetApiVersion();

            var merId = options.MerId;
            if (options.TestMode && (request is UnionPayForm05_7_FileTransferRequest || request is UnionPayForm_6_6_FileTransferRequest))
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

            if (request.HasEncryptCertId())
            {
                txtParams.Add(ENCRYPTCERTID, options.EncryptCertificate.certId);
            }

            UnionPaySignature.Sign(txtParams, options.SignCertificate.certId, options.SignCertificate.key, options.SecureKey);

            var query = UnionPayUtility.BuildQuery(txtParams);
            Logger?.LogTrace(0, "Request:{query}", query);

            using (var client = ClientFactory.CreateClient())
            {
                var body = await HttpClientUtility.DoPostAsync(client, request.GetRequestUrl(options.TestMode), query);
                Logger?.LogTrace(1, "Response:{content}", body);

                var dic = ParseQueryString(body);

                if (string.IsNullOrEmpty(body))
                {
                    throw new Exception("sign check fail: Body is Empty!");
                }

                var ifValidateCNName = !options.TestMode;
                if (!UnionPaySignature.Validate(dic, options.RootCertificate.cert, options.MiddleCertificate.cert, options.SecureKey, ifValidateCNName))
                {
                    throw new Exception("sign check fail: check Sign and Data Fail!");
                }

                var parser = new UnionPayDictionaryParser<T>();
                var rsp = parser.Parse(dic);
                rsp.Body = body;
                return rsp;
            }
        }

        #endregion

        #region IUnionPayClient Members

        public Task<T> PageExecuteAsync<T>(IUnionPayRequest<T> request) where T : UnionPayResponse
        {
            return PageExecuteAsync(request, null, "POST");
        }

        public Task<T> PageExecuteAsync<T>(IUnionPayRequest<T> request, string optionsName) where T : UnionPayResponse
        {
            return PageExecuteAsync(request, optionsName, "POST");
        }

        public Task<T> PageExecuteAsync<T>(IUnionPayRequest<T> request, string optionsName, string reqMethod) where T : UnionPayResponse
        {
            var options = string.IsNullOrEmpty(optionsName) ? OptionsSnapshotAccessor.Value : OptionsSnapshotAccessor.Get(optionsName);
            var version = string.IsNullOrEmpty(request.GetApiVersion()) ? options.Version : request.GetApiVersion();
            var txtParams = new UnionPayDictionary(request.GetParameters())
            {
                { VERSION, version },
                { ENCODING, options.Encoding },
                { SIGNMETHOD, options.SignMethod },
                { ACCESSTYPE, options.AccessType },
                { MERID, options.MerId }
            };

            UnionPaySignature.Sign(txtParams, options.SignCertificate.certId, options.SignCertificate.key, options.SecureKey);

            var rsp = Activator.CreateInstance<T>();

            var url = request.GetRequestUrl(options.TestMode);
            if (reqMethod.ToUpper() == "GET")
            {
                //拼接get请求的url
                var tmpUrl = url;
                if (txtParams != null && txtParams.Count > 0)
                {
                    if (tmpUrl.Contains("?"))
                    {
                        tmpUrl = tmpUrl + "&" + UnionPayUtility.BuildQuery(txtParams);
                    }
                    else
                    {
                        tmpUrl = tmpUrl + "?" + UnionPayUtility.BuildQuery(txtParams);
                    }
                }
                rsp.Body = tmpUrl;
            }
            else
            {
                //输出post表单
                rsp.Body = BuildHtmlRequest(url, txtParams, reqMethod);
            }

            return Task.FromResult(rsp);
        }

        #endregion

        #region Common Method

        private string BuildHtmlRequest(string url, UnionPayDictionary dicPara, string strMethod)
        {
            var sbHtml = new StringBuilder();
            sbHtml.Append("<form id='submit' name='submit' action='" + url + "' method='post' style='display:none;'>");
            foreach (var temp in dicPara)
            {
                sbHtml.Append("<input  name='" + temp.Key + "' value='" + temp.Value + "'/>");
            }
            sbHtml.Append("<input type='submit' style='display:none;'></form>");
            sbHtml.Append("<script>document.forms['submit'].submit();</script>");
            return sbHtml.ToString();
        }

        private static Dictionary<string, string> ParseQueryString(string str)
        {
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

        private static void PutKeyValueToDictionary(StringBuilder temp, bool isKey, string key, Dictionary<string, string> Dictionary)
        {
            if (isKey)
            {
                key = temp.ToString();
                if (key.Length == 0)
                {
                    throw new Exception("QueryString format illegal");
                }
                Dictionary[key] = string.Empty;
            }
            else
            {
                if (key.Length == 0)
                {
                    throw new Exception("QueryString format illegal");
                }
                Dictionary[key] = temp.ToString();
            }
        }

        #endregion
    }
}
