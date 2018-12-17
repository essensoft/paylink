using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.WeChatPay.Response;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Request
{
    /// <summary>
    /// 酒店押金 - 申请退款
    /// </summary>
    public class WeChatPayDepositRefundRequest : IWeChatPayCertificateRequest<WeChatPayDepositRefundResponse>
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        public string AppId { get; set; }

        /// <summary>
        /// 子商户公众账号ID
        /// </summary>
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        public string SubMchId { get; set; }

        /// <summary>
        /// 微信支付订单号
        /// </summary>
        public string TransactionId { get; set; }

        /// <summary>
        /// 押金退款单号
        /// </summary>
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        public int TotalFee { get; set; }

        /// <summary>
        /// 申请退款金额
        /// </summary>
        public int RefundFee { get; set; }

        /// <summary>
        /// 退款货币种类
        /// </summary>
        public string RefundFeeType { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        public string RefundDesc { get; set; }

        /// <summary>
        /// 退款资金来源
        /// </summary>
        public string RefundAccount { get; set; }

        #region IWeChatPayCertificateRequest Members

        public string GetRequestUrl()
        {
            return "https://api.mch.weixin.qq.com/deposit/refund";
        }

        public IDictionary<string, string> GetParameters()
        {
            var parameters = new WeChatPayDictionary
            {
                { "appid", AppId },
                { "sub_appid", SubAppId },
                { "sub_mch_id", SubMchId },
                { "transaction_id", TransactionId },
                { "out_refund_no", OutRefundNo },
                { "total_fee", TotalFee },
                { "refund_fee", RefundFee },
                { "refund_fee_type", RefundFeeType },
                { "refund_desc", RefundDesc },
                { "refund_account", RefundAccount },
            };
            return parameters;
        }

        public bool IsCheckResponseSign()
        {
            return true;
        }

        #endregion
    }
}
