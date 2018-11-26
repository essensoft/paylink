using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.JDPay.Response;

namespace Essensoft.AspNetCore.Payment.JDPay.Request
{
    /// <summary>
    /// 撤销申请接口
    /// </summary>
    public class JDPayRevokeRequest : IJDPayRequest<JDPayRevokeResponse>
    {
        /// <summary>
        /// 交易流水号
        /// </summary>
        public string TradeNum { get; set; }

        /// <summary>
        /// 原交易流水号
        /// </summary>
        public string OTradeNum { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        public string Amount { get; set; }

        /// <summary>
        /// 交易币种
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// 交易时间
        /// </summary>
        public string TradeTime { get; set; }

        /// <summary>
        /// 交易备注
        /// </summary>
        public string Note { get; set; }

        #region IJDPayRequest Members

        private string ApiVersion = "V2.0";

        public string GetRequestUrl()
        {
            return "https://paygate.jd.com/service/revoke";
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
            var parameters = new JDPayDictionary
            {
                { "tradeNum", TradeNum },
                { "oTradeNum", OTradeNum },
                { "amount", Amount },
                { "currency", Currency },
                { "tradeTime", TradeTime },
                { "note", Note }
            };
            return parameters;
        }

        #endregion
    }
}
