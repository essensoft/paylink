using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.LianLianPay.Parser;
using Essensoft.AspNetCore.Payment.LianLianPay.Request;
using Essensoft.AspNetCore.Payment.LianLianPay.Utility;
using Essensoft.AspNetCore.Payment.Security;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    public class LianLianPayClient : ILianLianPayClient
    {
        private const string VERSION = "version";
        private const string OID_PARTNER = "oid_partner";
        private const string SIGN_TYPE = "sign_type";
        private const string BUSI_PARTNER = "busi_partner";
        private const string TIMESTAMP = "timestamp";
        private const string SIGN = "sign";

        public virtual ILogger Logger { get; set; }

        public virtual IHttpClientFactory ClientFactory { get; set; }

        public LianLianPayOptions Options { get; protected set; }

        #region LianLianPayClient Constructors

        public LianLianPayClient(
            ILogger<LianLianPayClient> logger,
            IHttpClientFactory clientFactory,
            IOptions<LianLianPayOptions> optionsAccessor)
        {
            Logger = logger;
            ClientFactory = clientFactory;
            Options = optionsAccessor.Value;

            if (string.IsNullOrEmpty(Options.OidPartner))
            {
                throw new ArgumentNullException(nameof(Options.OidPartner));
            }

            if (string.IsNullOrEmpty(Options.BusiPartner))
            {
                throw new ArgumentNullException(nameof(Options.BusiPartner));
            }

            if (string.IsNullOrEmpty(Options.RsaPrivateKey))
            {
                throw new ArgumentNullException(nameof(Options.RsaPrivateKey));
            }

            if (string.IsNullOrEmpty(Options.RsaPublicKey))
            {
                throw new ArgumentNullException(nameof(Options.RsaPublicKey));
            }           
        }

        #endregion

        #region ILianLianPayClient Members

        public async Task<T> ExecuteAsync<T>(ILianLianPayRequest<T> request) where T : LianLianPayResponse
        {
            // 字典排序
            var txtParams = new LianLianPayDictionary(request.GetParameters())
            {
                { OID_PARTNER, Options.OidPartner },
                { SIGN_TYPE, Options.SignType },
            };

            // 添加签名
            var signContent = LianLianPaySecurity.GetSignContent(txtParams);
            txtParams.Add(SIGN, MD5WithRSA.SignData(signContent, Options.PrivateKey));

            var content = string.Empty;
            if (request is LianLianPayPaymentRequest || request is LianLianPayConfirmPaymentRequest)
            {
                var plaintext = Serialize(txtParams);
                var ciphertext = LianLianPaySecurity.Encrypt(plaintext, Options.PublicKey);
                content = @"{""pay_load"":""" + ciphertext + @""",""oid_partner"":""" + Options.OidPartner + @"""}";
            }
            else
            {
                content = Serialize(txtParams);
            }
            Logger?.LogTrace(0, "Request:{content}", content);

            using (var client = ClientFactory.CreateClient(LianLianPayOptions.DefaultClientName))
            {
                var body = await HttpClientUtility.DoPostAsync(client, request.GetRequestUrl(), content);
                Logger?.LogTrace(1, "Response:{body}", body);

                var parser = new LianLianPayJsonParser<T>();
                var rsp = parser.Parse(body);

                // 不签名参数
                var excludePara = new List<string>();
                if (request is LianLianPayOrderQueryRequest)
                {
                    excludePara.Add("bank_name");
                    excludePara.Add("card_no");
                }
                else if (request is LianLianPayQueryBankCarBindListRequest)
                {
                    excludePara.Add("agreement_list");
                }

                CheckNotifySign(rsp.Parameters, excludePara);
                return rsp;
            }
        }

        #endregion

        #region ILianLianPayClient Members

        public Task<T> PageExecuteAsync<T>(ILianLianPayRequest<T> request) where T : LianLianPayResponse
        {
            return PageExecuteAsync(request, "POST");
        }

        public Task<T> PageExecuteAsync<T>(ILianLianPayRequest<T> request, string reqMethod) where T : LianLianPayResponse
        {
            var txtParams = new LianLianPayDictionary(request.GetParameters())
            {
                { OID_PARTNER, Options.OidPartner },
                { SIGN_TYPE, Options.SignType },
                { BUSI_PARTNER, Options.BusiPartner },
                { TIMESTAMP, DateTime.Now },
            };

            // 添加签名
            var signContent = LianLianPaySecurity.GetSignContent(txtParams);
            txtParams.Add(SIGN, MD5WithRSA.SignData(signContent, Options.PrivateKey));

            var body = string.Empty;

            if (reqMethod.ToUpper() == "GET")
            {
                //拼接get请求的url
                var tmpUrl = request.GetRequestUrl();
                if (txtParams != null && txtParams.Count > 0)
                {
                    if (tmpUrl.Contains("?"))
                    {
                        tmpUrl = tmpUrl + "&" + LianLianPayUtility.BuildQuery(txtParams);
                    }
                    else
                    {
                        tmpUrl = tmpUrl + "?" + LianLianPayUtility.BuildQuery(txtParams);
                    }
                }
                body = tmpUrl;
                Logger?.LogTrace(0, "Request Url:{body}", body);
            }
            else
            {
                //输出post表单
                body = BuildHtmlRequest(request.GetRequestUrl(), txtParams);
                Logger?.LogTrace(0, "Request Html:{body}", body);
            }

            var parser = new LianLianPayJsonParser<T>();
            var rsp = parser.Parse(body);
            return Task.FromResult(rsp);
        }

        #endregion

        #region ILianLianPayClient Members

        public Task<T> PageReqDataExecuteAsync<T>(ILianLianPayRequest<T> request) where T : LianLianPayResponse
        {
            // 字典排序
            var txtParams = new LianLianPayDictionary(request.GetParameters())
            {
                { OID_PARTNER, Options.OidPartner },
                { SIGN_TYPE, Options.SignType },
                { BUSI_PARTNER, Options.BusiPartner },
            };

            // 添加签名
            var signContent = LianLianPaySecurity.GetSignContent(txtParams);
            txtParams.Add(SIGN, MD5WithRSA.SignData(signContent, Options.PrivateKey));

            var content = Serialize(txtParams);
            Logger?.LogTrace(0, "Request:{content}", content);

            var body = BuildReqDataHtmlRequest(request.GetRequestUrl(), content);
            var parser = new LianLianPayJsonParser<T>();
            var rsp = parser.Parse(body);
            return Task.FromResult(rsp);
        }

        #endregion

        #region Common Method

        private string BuildHtmlRequest(string url, IDictionary<string, string> sParaTemp)
        {
            //待请求参数数组
            var dicPara = new Dictionary<string, string>(sParaTemp);

            var sbHtml = new StringBuilder();
            sbHtml.Append("<form id='submit' name='submit' action='" + url + "' method='post' style='display:none;'>");
            foreach (var temp in dicPara)
            {
                sbHtml.Append("<input  name='" + temp.Key + "' value='" + temp.Value + "'/>");
            }
            sbHtml.Append("<input type='submit' style='display:none;'></form>");
            //表单实现自动提交
            sbHtml.Append("<script>document.forms['submit'].submit();</script>");

            return sbHtml.ToString();
        }

        private string BuildReqDataHtmlRequest(string url, string data)
        {
            var sbHtml = new StringBuilder();
            sbHtml.Append("<form id='submit' name='submit' action='" + url + "' method='post' style='display:none;'>");
            sbHtml.Append("<input  name='req_data' value='" + data + "'/>");
            sbHtml.Append("<input type='submit' style='display:none;'></form>");
            sbHtml.Append("<script>document.forms['submit'].submit();</script>");
            return sbHtml.ToString();
        }

        private string Serialize(object value)
        {
            return JsonConvert.SerializeObject(value, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
        }

        private void CheckNotifySign(LianLianPayDictionary parameters, List<string> excludePara)
        {
            if (parameters.Count == 0)
            {
                throw new Exception("sign check fail: para is Empty!");
            }

            if (parameters.TryGetValue("sign", out var sign))
            {
                var prestr = LianLianPaySecurity.GetSignContent(parameters, excludePara);
                if (!MD5WithRSA.VerifyData(prestr, sign, Options.PublicKey))
                {
                    throw new Exception("sign check fail: check Sign and Data Fail JSON also");
                }
            }
        }

        #endregion
    }
}
