using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Response;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Request
{
    /// <summary>
    /// 付款结果查询
    /// </summary>
    public class LianLianPayQueryPaymentRequest : ILianLianPayRequest<LianLianPayQueryPaymentResponse>
    {
        /// <summary>
        /// 平台来源
        /// </summary>
        public string Platform { get; set; }

        /// <summary>
        /// 商户付款流水号
        /// </summary>
        public string NoOrder { get; set; }

        /// <summary>
        /// 连连支付单号
        /// </summary>
        public string OidPaybill { get; set; }

        #region ILianLianPayRequest

        private string ApiVersion = "1.0";

        public string GetRequestUrl()
        {
            return "https://instantpay.lianlianpay.com/paymentapi/queryPayment.htm";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new LianLianPayDictionary
            {
                { "platform", Platform },
                { "no_order", NoOrder },
                { "oid_paybill", OidPaybill },
                { "api_version", ApiVersion },
            };
            return parameters;
        }

        public string GetApiVersion()
        {
            return ApiVersion;
        }

        public void SetApiVersion(string apiVersion)
        {
            ApiVersion = apiVersion;
        }

        #endregion
    }
}
