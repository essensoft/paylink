using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.QPay.Response;

namespace Essensoft.AspNetCore.Payment.QPay.Request
{
    /// <summary>
    /// 企业付款 - 查询企业付款
    /// </summary>
    public class QPayEPayQueryRequest : IQPayRequest<QPayEPayQueryResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// QQ钱包订单号
        /// </summary>
        public string TransactionId { get; set; }

        #region IQPayRequest Members

        public string GetRequestUrl()
        {
            return "https://qpay.qq.com/cgi-bin/pay/qpay_epay_query.cgi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new QPayDictionary
            {
                { "out_trade_no", OutTradeNo },
                { "transaction_id", TransactionId },
            };
            return parameters;
        }

        public bool IsCheckResponseSign()
        {
            return false;
        }

        #endregion
    }
}
