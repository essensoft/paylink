using System;
using System.Collections.Generic;
using System.Net.Http;
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
        private const string TIME_STAMP = "time_stamp";
        private const string SIGN = "sign";

        #region LianLianPayClient Constructors

        public LianLianPayClient(
            ILogger<LianLianPayClient> logger,
            IHttpClientFactory clientFactory,
            IOptionsSnapshot<LianLianPayOptions> optionsAccessor)
        {
            Logger = logger;
            ClientFactory = clientFactory;
            OptionsSnapshotAccessor = optionsAccessor;
        }

        #endregion

        public ILogger Logger { get; set; }

        public IHttpClientFactory ClientFactory { get; set; }

        public IOptionsSnapshot<LianLianPayOptions> OptionsSnapshotAccessor { get; set; }

        #region ILianLianPayClient Members

        public async Task<T> ExecuteAsync<T>(ILianLianPayRequest<T> request) where T : LianLianPayResponse
        {
            return await ExecuteAsync(request, null);
        }

        public async Task<T> ExecuteAsync<T>(ILianLianPayRequest<T> request, string optionsName) where T : LianLianPayResponse
        {
            var options = string.IsNullOrEmpty(optionsName) ? OptionsSnapshotAccessor.Value : OptionsSnapshotAccessor.Get(optionsName);
            // 字典排序
            var txtParams = new LianLianPayDictionary(request.GetParameters())
            {
                { OID_PARTNER, options.OidPartner },
                { SIGN_TYPE, options.SignType }
            };

            if (request is LianLianPayCreateBillRequest || request is LianLianPayUnifiedCardBindRequest)
            {
                txtParams.Add(TIME_STAMP, DateTime.Now);
                txtParams.Add(BUSI_PARTNER, options.BusiPartner);
            }

            // 添加签名
            var signContent = LianLianPaySecurity.GetSignContent(txtParams);
            txtParams.Add(SIGN, MD5WithRSA.SignData(signContent, options.PrivateKey));

            var content = string.Empty;
            if (request is LianLianPayPaymentRequest || request is LianLianPayConfirmPaymentRequest)
            {
                var plaintext = Serialize(txtParams);
                var ciphertext = LianLianPaySecurity.Encrypt(plaintext, options.PublicKey);
                content = $"{{\"pay_load\":\"{ciphertext}\",\"oid_partner\":\"{options.OidPartner}\"}}";
            }
            else
            {
                content = Serialize(txtParams);
            }
            Logger.Log(options.LogLevel, "Request:{content}", content);

            using (var client = ClientFactory.CreateClient())
            {
                var body = await client.DoPostAsync(request.GetRequestUrl(), content);
                Logger.Log(options.LogLevel, "Response:{body}", body);

                var parser = new LianLianPayJsonParser<T>();
                var rsp = parser.Parse(body);

                // 不签名参数
                var excludePara = new List<string>();
                if (request is LianLianPayOrderQueryRequest)
                {
                    excludePara.Add("bank_name");
                    excludePara.Add("card_no");
                }
                else if (request is LianLianPayQueryBankCardBindListRequest)
                {
                    excludePara.Add("agreement_list");
                }

                CheckNotifySign(rsp.Parameters, excludePara, options);
                return rsp;
            }
        }

        #endregion

        #region Common Method

        private string Serialize(object value)
        {
            return JsonConvert.SerializeObject(value, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        private void CheckNotifySign(LianLianPayDictionary parameters, List<string> excludePara, LianLianPayOptions options)
        {
            if (parameters.Count == 0)
            {
                throw new Exception("sign check fail: para is Empty!");
            }

            if (parameters.TryGetValue("sign", out var sign))
            {
                var prestr = LianLianPaySecurity.GetSignContent(parameters, excludePara);
                if (!MD5WithRSA.VerifyData(prestr, sign, options.PublicKey))
                {
                    throw new Exception("sign check fail: check Sign and Data Fail JSON also");
                }
            }
        }

        #endregion
    }
}
