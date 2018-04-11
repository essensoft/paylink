using Essensoft.AspNetCore.Payment.LianLianPay.Parser;
using Essensoft.AspNetCore.Payment.LianLianPay.Request;
using Essensoft.AspNetCore.Payment.LianLianPay.Utility;
using Essensoft.AspNetCore.Payment.Security;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

        private AsymmetricKeyParameter PrivateKey;
        private AsymmetricKeyParameter PublicKey;

        public LianLianPayOptions Options { get; set; }

        public virtual ILogger<LianLianPayClient> Logger { get; set; }

        protected internal HttpClientEx Client { get; set; }

        public LianLianPayClient(
            IOptions<LianLianPayOptions> optionsAccessor,
            ILogger<LianLianPayClient> logger)
        {
            Options = optionsAccessor?.Value ?? new LianLianPayOptions();
            Logger = logger;

            Client = new HttpClientEx();

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

            PrivateKey = RSAUtilities.GetKeyParameterFormPrivateKey(Options.RsaPrivateKey);
            PublicKey = RSAUtilities.GetKeyParameterFormPublicKey(Options.RsaPublicKey);
        }

        public void SetTimeout(int timeout)
        {
            Client.Timeout = new TimeSpan(0, 0, 0, timeout);
        }

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
            txtParams.Add(SIGN, MD5WithRSA.SignData(signContent, PrivateKey));

            var content = string.Empty;
            if (request is LianLianPayPaymentRequest || request is LianLianPayConfirmPaymentRequest)
            {
                var plaintext = JsonConvert.SerializeObject(txtParams, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
                var ciphertext = LianLianPaySecurity.Encrypt(plaintext, PublicKey);
                content = @"{""pay_load"":""" + ciphertext + @""",""oid_partner"":""" + Options.OidPartner + @"""}";
            }
            else
            {
                content = JsonConvert.SerializeObject(txtParams, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
            }
            Logger.LogInformation(0, "Request:{content}", content);

            var rspContent = await Client.DoPostAsync(request.GetRequestUrl(), content);
            Logger.LogInformation(1, "Response:{content}", rspContent);

            var parser = new LianLianPayJsonParser<T>();
            var rsp = parser.Parse(rspContent);

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
            txtParams.Add(SIGN, MD5WithRSA.SignData(signContent, PrivateKey));

            var body = string.Empty;

            if (reqMethod == "GET")
            {
                //拼接get请求的url
                var tmpUrl = request.GetRequestUrl();
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
                body = tmpUrl;
                Logger.LogInformation(0, "Request Url:{body}", body);
            }
            else
            {
                //输出post表单
                body = BuildHtmlRequest(request.GetRequestUrl(), txtParams);
                Logger.LogInformation(0, "Request Html:{body}", body);
            }

            var parser = new LianLianPayJsonParser<T>();
            var rsp = parser.Parse(body);
            return Task.FromResult(rsp);
        }

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

        private void CheckNotifySign(LianLianPayDictionary para, List<string> excludePara)
        {
            if (para.Count == 0)
            {
                throw new Exception("sign check fail: para is Empty!");
            }

            if (para.TryGetValue("sign", out var sign))
            {
                var prestr = LianLianPaySecurity.GetSignContent(para, excludePara);
                if (!MD5WithRSA.VerifyData(prestr, sign, PublicKey))
                {
                    throw new Exception("sign check fail: check Sign and Data Fail JSON also");
                }
            }
        }
    }
}
