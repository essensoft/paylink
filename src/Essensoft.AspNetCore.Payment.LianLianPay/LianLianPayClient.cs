using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Essensoft.AspNetCore.Payment.LianLianPay.Parser;
using Essensoft.AspNetCore.Payment.LianLianPay.Request;
using Essensoft.AspNetCore.Payment.LianLianPay.Utility;
using Essensoft.AspNetCore.Payment.Security;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay
{
    /// <summary>
    /// LianLianPay 客户端。
    /// </summary>
    public class LianLianPayClient : ILianLianPayClient
    {
        private const string OID_PARTNER = "oid_partner";
        private const string SIGN_TYPE = "sign_type";
        private const string BUSI_PARTNER = "busi_partner";
        private const string TIME_STAMP = "time_stamp";
        private const string SIGN = "sign";

        private readonly IHttpClientFactory _httpClientFactory;

        #region LianLianPayClient Constructors

        public LianLianPayClient(
            IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        #endregion

        #region ILianLianPayClient Members

        public async Task<T> ExecuteAsync<T>(ILianLianPayRequest<T> request, LianLianPayOptions options) where T : LianLianPayResponse
        {
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

            using (var client = _httpClientFactory.CreateClient(nameof(LianLianPay)))
            {
                var body = await client.DoPostAsync(request.GetRequestUrl(), content);
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

                CheckNotifySign(rsp, excludePara, options);
                return rsp;
            }
        }

        #endregion

        #region Common Method

        private string Serialize(object value)
        {
            return JsonConvert.SerializeObject(value, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        private void CheckNotifySign(LianLianPayResponse response, List<string> excludePara, LianLianPayOptions options)
        {
            if (string.IsNullOrEmpty(response.Body))
            {
                throw new LianLianPayException("sign check fail: Body is Empty!");
            }

            if (response.Parameters.Count == 0)
            {
                throw new LianLianPayException("sign check fail: Parameters is Empty!");
            }

            if (!response.Parameters.TryGetValue("sign", out var sign))
            {
                throw new LianLianPayException("sign check fail: sign is Empty!");
            }

            var prestr = LianLianPaySecurity.GetSignContent(response.Parameters, excludePara);
            if (!MD5WithRSA.VerifyData(prestr, sign, options.PublicKey))
            {
                throw new LianLianPayException("sign check fail: check Sign and Data Fail JSON also");
            }
        }

        #endregion
    }
}
