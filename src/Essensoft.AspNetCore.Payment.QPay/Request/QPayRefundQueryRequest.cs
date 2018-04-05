using Essensoft.AspNetCore.Payment.QPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.QPay.Request
{
    public class QPayRefundQueryRequest : IQPayRequest<QPayRefundQueryResponse>
    {
        /// <summary>
        /// QQ钱包退款单号
        /// </summary>
        public string RefundId { get; set; }

        /// <summary>
        /// 商户退款单号
        /// </summary>
        public string OutRefundNo { get; set; }

        /// <summary>
        /// QQ钱包订单号
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        #region IQPayRequest Members

        public string GetRequestUrl()
        {
            return "https://qpay.qq.com/cgi-bin/pay/qpay_refund_query.cgi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new QPayDictionary()
            {
                { "refund_id", RefundId },
                { "out_refund_no", OutRefundNo },
                { "transaction_id", TransactionId },
                { "out_trade_no", OutTradeNo }
            };
            return parameters;
        }

        #endregion
    }
}
