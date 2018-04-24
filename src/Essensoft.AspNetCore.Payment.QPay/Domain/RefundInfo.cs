using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.QPay.Domain
{
    public class RefundInfo
    {
        /// <summary>
        /// 商户退款单号
        /// </summary>
        [XmlElement("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// QQ钱包退款单号
        /// </summary>
        [XmlElement("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 退款方式
        /// </summary>
        [XmlElement("refund_channel")]
        public string RefundChannel { get; set; }

        /// <summary>
        /// 申请退款金额
        /// </summary>
        [XmlElement("refund_fee")]
        public int RefundFee { get; set; }

        /// <summary>
        /// 退款申请金额中，优惠或者立减的金额
        /// </summary>
        [XmlElement("coupon_refund_fee")]
        public int CouponRefundFee { get; set; }

        /// <summary>
        /// 退款申请中的现金金额
        /// </summary>
        [XmlElement("cash_refund_fee")]
        public int CashRefundFee { get; set; }

        /// <summary>
        /// 退款状态定义
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款入账账户
        /// </summary>
        [XmlElement("refund_recv_accout")]
        public string RefundRecvAccout { get; set; }
    }
}
