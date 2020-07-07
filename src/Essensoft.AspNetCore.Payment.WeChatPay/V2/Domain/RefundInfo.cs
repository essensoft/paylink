using System.Collections.Generic;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Domain
{
    /// <summary>
    /// 退款信息
    /// </summary>
    public class RefundInfo : WeChatPayObject
    {
        /// <summary>
        /// 商户退款单号
        /// </summary>
        [XmlElement("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 微信退款单号
        /// </summary>
        [XmlElement("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 退款渠道
        /// </summary>
        [XmlElement("refund_channel")]
        public string RefundChannel { get; set; }

        /// <summary>
        /// 申请退款金额
        /// </summary>
        [XmlElement("refund_fee")]
        public int RefundFee { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [XmlElement("settlement_refund_fee")]
        public int SettlementRefundFee { get; set; }

        /// <summary>
        /// 总代金券退款金额
        /// </summary>
        [XmlElement("coupon_refund_fee")]
        public int CouponRefundFee { get; set; }

        /// <summary>
        /// 退款代金券使用数量
        /// </summary>
        [XmlElement("coupon_refund_count")]
        public int CouponRefundCount { get; set; }

        /// <summary>
        /// 退款代金券
        /// </summary>
        [XmlIgnore]
        public List<CouponRefundInfo> CouponRefunds { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款资金来源
        /// </summary>
        [XmlElement("refund_account")]
        public string RefundAccount { get; set; }

        /// <summary>
        /// 退款入账账户
        /// </summary>
        [XmlElement("refund_recv_accout")]
        public string RefundRecvAccout { get; set; }

        /// <summary>
        /// 退款成功时间
        /// </summary>
        [XmlElement("refund_success_time")]
        public string RefundSuccessTime { get; set; }
    }
}
