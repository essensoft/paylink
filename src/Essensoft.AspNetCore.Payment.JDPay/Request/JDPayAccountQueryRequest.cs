using Essensoft.AspNetCore.Payment.JDPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.JDPay.Request
{
    /// <summary>
    /// 余额查询接口
    /// </summary>
    public class JDPayAccountQueryRequest : IJDPayNPP10Request<JDPayAccountQueryResponse>
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
        /// 外部订单日
        /// </summary>
        public string OutTradeDate { get; set; }

        /// <summary>
        /// 会员信息
        /// </summary>
        public string BuyerInfo { get; set; }

        /// <summary>
        /// 查询类型
        /// </summary>
        public string QueryType { get; set; }

        /// <summary>
        /// 账户类型码
        /// </summary>
        public string LedgerType { get; set; }

        #region IJDPayNPP10Request

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new JDPayDictionary()
            {
                { "request_datetime", RequestDatetime },
                { "out_trade_no",  OutTradeNo },
                { "out_trade_date", OutTradeDate },
                { "buyer_info", BuyerInfo },
                { "query_type", QueryType },
                { "ledger_type", LedgerType },
            };

            return parameters;
        }

        public string GetRequestUrl()
        {
            return "https://mapi.jdpay.com/npp10/account_query";
        }

        #endregion
    }
}
