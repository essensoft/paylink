using Essensoft.AspNetCore.Payment.QPay.Response;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.QPay.Request
{
    public class QPayRefundRequest : IQPayCertificateRequest<QPayRefundResponse>
    {
        /// <summary>
        /// QQ钱包订单号
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 商户退款单号
        /// </summary>
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 退款申请金额
        /// </summary>
        public int RefundFee { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string OpUserId { get; set; }

        /// <summary>
        /// 操作员密码的MD5
        /// </summary>
        public string OpUserPasswd { get; set; }

        /// <summary>
        /// 退款资金来源
        /// </summary>
        public string RefundAccount { get; set; }

        #region IQPayRequest Members

        public string GetRequestUrl()
        {
            return "https://api.qpay.qq.com/cgi-bin/pay/qpay_refund.cgi";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new QPayDictionary()
            {
                { "transaction_id", TransactionId },
                { "out_trade_no", OutTradeNo },
                { "out_refund_no", OutRefundNo },
                { "refund_fee", RefundFee.ToString() },
                { "op_user_id", OpUserId },
                { "op_user_passwd", OpUserPasswd },
                { "refund_account", RefundAccount }
            };
            return parameters;
        }

        #endregion
    }
}
