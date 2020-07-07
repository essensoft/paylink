using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V2.Domain
{
    /// <summary>
    /// 代金券或立减优惠信息
    /// </summary>
    public class CouponInfo : WeChatPayObject
    {
        /// <summary>
        /// 代金券类型
        /// </summary>
        [XmlElement("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 代金券或立减优惠ID
        /// </summary>
        [XmlElement("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 代金券或立减优惠金额
        /// </summary>
        [XmlElement("coupon_fee")]
        public int CouponFee { get; set; }
    }
}
