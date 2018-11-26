using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.JDPay.Response;

namespace Essensoft.AspNetCore.Payment.JDPay.Request
{
    /// <summary>
    /// 交易查询接口
    /// </summary>
    public class JDPayTradeQueryRequest : IJDPayNPP10Request<JDPayTradeQueryResponse>
    {
        /// <summary>
        /// 请求时间
        /// </summary>
        public string RequestDatetime { get; set; }

        /// <summary>
        /// 商户订单流水号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        public string TradeNo { get; set; }

        /// <summary>
        /// 查询类型
        /// </summary>
        public string TradeType { get; set; }

        #region IJDPayNPP10Request

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new JDPayDictionary
            {
                { "request_datetime", RequestDatetime },
                { "out_trade_no",  OutTradeNo },
                { "trade_no", TradeNo },
                { "trade_type", TradeType }
            };

            return parameters;
        }

        public string GetRequestUrl()
        {
            return "https://mapi.jdpay.com/npp10/trade_query";
        }

        #endregion
    }
}
