using Essensoft.AspNetCore.JdPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.JdPay.Request
{
    public class JdPayRefundQueryRequest : IJdPayRequest<JdPayRefundQueryResponse>
    {
        /// <summary>
        /// 交易流水号
        /// </summary>
        public string TradeNum { set; get; }

        /// <summary>
        /// 原交易流水号
        /// </summary>
        public string OTradeNum { set; get; }

        #region IJdPayRequest Members

        private string ApiVersion = "V2.0";

        public string GetRequestUrl()
        {
            return "https://paygate.jd.com/service/query";
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

        public IDictionary<string, string> GetEncryptParameters()
        {
            return null;
        }

        #endregion
    }
}
