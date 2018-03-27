using Essensoft.AspNetCore.Payment.JdPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.JdPay.Request
{
    /// <summary>
    /// 交易查询接口
    /// </summary>
    public class JdPayOrderQueryRequest : IJdPayRequest<JdPayOrderQueryResponse>
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
                { "tradeType", 0 }, // 消费
            };
            return parameters;
        }

        #endregion
    }
}
