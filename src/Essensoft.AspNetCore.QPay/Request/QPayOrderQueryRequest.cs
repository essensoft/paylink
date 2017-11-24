using Essensoft.AspNetCore.QPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.QPay.Request
{
    public class QPayOrderQueryRequest : IQPayRequest<QPayOrderQueryResponse>
    {
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
            return "https://qpay.qq.com/cgi-bin/pay/qpay_order_query.cgi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new QPayDictionary()
            {
                { "transaction_id", TransactionId },
                { "out_trade_no", OutTradeNo }
            };
            return parameters;
        }

        #endregion
    }
}
