using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Domain
{
    /// <summary>
    /// 退款代金券信息
    /// </summary>
    public class CouponRefundInfo : WeChatPayObject
    {
        /// <summary>
        /// 代金券类型
        /// </summary>
        [XmlElement("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 退款代金券ID
        /// </summary>
        [XmlElement("coupon_refund_id")]
        public string CouponRefundId { get; set; }

        /// <summary>
        /// 单个代金券退款金额
        /// </summary>
        [XmlElement("coupon_refund_fee")]
        public int CouponRefundFee { get; set; }
    }
}
