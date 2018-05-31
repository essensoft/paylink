using Essensoft.AspNetCore.Payment.UnionPay.Parser;
using Essensoft.AspNetCore.Payment.UnionPay.Request;
using Essensoft.AspNetCore.Payment.UnionPay.Utility;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        private readonly UnionPayCertificate SignCertificate;
        private readonly UnionPayCertificate EncryptCertificate;
        private readonly UnionPayCertificate MiddleCertificate;
        private readonly UnionPayCertificate RootCertificate;

        public UnionPayOptions Options { get; }

        public virtual ILogger Logger { get; set; }

        protected internal HttpClientEx Client { get; set; }

        #region UnionPayClient Constructors

        public UnionPayClient(
            IOptions<UnionPayOptions> optionsAccessor,
            ILogger<UnionPayClient> logger)
        {
            Options = optionsAccessor.Value;
            Logger = logger;
            Client = new HttpClientEx();

            if (string.IsNullOrEmpty(Options.SignCert))
            {
                throw new ArgumentNullException(nameof(Options.SignCert));
            }

            if (string.IsNullOrEmpty(Options.SignCertPassword))
            {
                throw new ArgumentNullException(nameof(Options.SignCertPassword));
            }

            if (string.IsNullOrEmpty(Options.EncryptCert))
            {
                throw new ArgumentNullException(nameof(Options.EncryptCert));
            }

            if (string.IsNullOrEmpty(Options.MiddleCert))
            {
                throw new ArgumentNullException(nameof(Options.MiddleCert));
            }

            if (string.IsNullOrEmpty(Options.RootCert))
            {
                throw new ArgumentNullException(nameof(Options.RootCert));
            }

            SignCertificate = UnionPaySignature.GetSignCertificate(Options.SignCert, Options.SignCertPassword);
            EncryptCertificate = UnionPaySignature.GetCertificate(Options.EncryptCert);
            MiddleCertificate = UnionPaySignature.GetCertificate(Options.MiddleCert);
            RootCertificate = UnionPaySignature.GetCertificate(Options.RootCert);
        }

        public UnionPayClient(IOptions<UnionPayOptions> optionsAccessor)
            : this(optionsAccessor, null)
        { }

        #endregion

        #region IUnionPayClient Members

        public void SetTimeout(int timeout)
        {
            Client.Timeout = new TimeSpan(0, 0, 0, timeout);
        }

        #endregion

        #region IUnionPayClient Members

        public async Task<T> ExecuteAsync<T>(IUnionPayRequest<T> request) where T : UnionPayResponse
        {
            var version = string.Empty;

            if (!string.IsNullOrEmpty(request.GetApiVersion()))
            {
                version = request.GetApiVersion();
            }
            else
            {
                version = Options.Version;
            }

            var merId = Options.MerId;
            if (Options.TestMode && (request is UnionPayForm05_7_FileTransferRequest || request is UnionPayForm_6_6_FileTransferRequest))
            {
                merId = "700000000000001";
            }

            var txtParams = new UnionPayDictionary(request.GetParameters())
            {
                { VERSION, version },
                { ENCODING, Options.Encoding },
                { SIGNMETHOD, Options.SignMethod },
                { ACCESSTYPE, Options.AccessType },
                { MERID, merId },
            };

            if (request.HasEncryptCertId())
            {
                txtParams.Add(ENCRYPTCERTID, EncryptCertificate.certId);
            }

            UnionPaySignature.Sign(txtParams, SignCertificate.certId, SignCertificate.key, Options.SecureKey);

            var query = HttpClientEx.BuildQuery(txtParams);
            Logger?.LogTrace(0, "Request:{query}", query);

            var body = await Client.DoPostAsync(request.GetRequestUrl(Options.TestMode), query);
            Logger?.LogTrace(1, "Response:{content}", body);

            var dic = ParseQueryString(body);

            if (string.IsNullOrEmpty(body))
            {
                throw new Exception("sign check fail: Body is Empty!");
            }

            var ifValidateCNName = !Options.TestMode;
            if (!UnionPaySignature.Validate(dic, RootCertificate.cert, MiddleCertificate.cert, Options.SecureKey, ifValidateCNName))
            {
                throw new Exception("sign check fail: check Sign and Data Fail!");
            }

            var parser = new UnionPayDictionaryParser<T>();
            var rsp = parser.Parse(dic);
            rsp.Body = body;
            return rsp;
        }

        #endregion

        #region IUnionPayClient Members

        public Task<T> PageExecuteAsync<T>(IUnionPayRequest<T> request) where T : UnionPayResponse
        {
            return PageExecuteAsync(request, "POST");
        }

        public Task<T> PageExecuteAsync<T>(IUnionPayRequest<T> request, string reqMethod) where T : UnionPayResponse
        {
            var version = string.Empty;

            if (!string.IsNullOrEmpty(request.GetApiVersion()))
            {
                version = request.GetApiVersion();
            }
            else
            {
                version = Options.Version;
            }

            var txtParams = new UnionPayDictionary(request.GetParameters())
            {
                { VERSION, version },
                { ENCODING, Options.Encoding },
                { SIGNMETHOD, Options.SignMethod },
                { ACCESSTYPE, Options.AccessType },
                { MERID, Options.MerId },
            };

            UnionPaySignature.Sign(txtParams, SignCertificate.certId, SignCertificate.key, Options.SecureKey);

            var rsp = Activator.CreateInstance<T>();

            var url = request.GetRequestUrl(Options.TestMode);
            if (reqMethod.ToUpper() == "GET")
            {
                //拼接get请求的url
                var tmpUrl = url;
                if (txtParams != null && txtParams.Count > 0)
                {
                    if (tmpUrl.Contains("?"))
                    {
                        tmpUrl = tmpUrl + "&" + HttpClientEx.BuildQuery(txtParams);
                    }
                    else
                    {
                        tmpUrl = tmpUrl + "?" + HttpClientEx.BuildQuery(txtParams);
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
