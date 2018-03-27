using Essensoft.AspNetCore.Payment.QPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.QPay.Request
{
    public class QPayCloseOrderRequest : IQPayRequest<QPayCloseOrderResponse>
    {
        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        public string TotalFee { get; set; }

        #region IQPayRequest Members

        public string GetRequestUrl()
        {
            return "https://qpay.qq.com/cgi-bin/pay/qpay_close_order.cgi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new QPayDictionary()
            {
                { "out_trade_no", OutTradeNo },
                { "total_fee", TotalFee }
            };
            return parameters;
        }

        #endregion
    }
}
