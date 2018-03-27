using Essensoft.AspNetCore.Payment.JdPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.JdPay.Request
{
    /// <summary>
    /// 正单号退款查询接口
    /// </summary>
    public class JdPayQueryRefundRequest : IJdPayRequest<JdPayQueryRefundResponse>
    {
        /// <summary>
        /// 交易流水号
        /// </summary>
        public string TradeNum { get; set; }

        /// <summary>
        /// 原交易流水号
        /// </summary>
        public string OTradeNum { get; set; }

        #region IJdPayRequest Members

        private string ApiVersion = "V2.0";

        public string GetRequestUrl()
        {
            return "https://paygate.jd.com/service/queryRefund ";
        }

        public void SetApiVersion(string apiVersion)
        {
            ApiVersion = apiVersion;
        }

        public string GetApiVersion()
        {
            return ApiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new JdPayDictionary()
            {
                { "tradeNum", TradeNum },
                { "oTradeNum", OTradeNum },
                { "tradeType", 1 }, // 退款
            };
            return parameters;
        }

        #endregion
    }
}
