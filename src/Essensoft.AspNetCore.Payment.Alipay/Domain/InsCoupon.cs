using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsCoupon Data Structure.
    /// </summary>
    [Serializable]
    public class InsCoupon : AlipayObject
    {
        /// <summary>
        /// 实际使用的权益值，可选不唯一，可能是金额（分），也可能是业务约定的其他描述
        /// </summary>
        [JsonProperty("actual_coupon_value")]
        [XmlElement("actual_coupon_value")]
        public string ActualCouponValue { get; set; }

        /// <summary>
        /// 实际使用的折扣金额（分），可选不唯一
        /// </summary>
        [JsonProperty("actual_discount_cash")]
        [XmlElement("actual_discount_cash")]
        public long ActualDiscountCash { get; set; }

        /// <summary>
        /// 权益ID，必选不唯一，营销域分配
        /// </summary>
        [JsonProperty("coupon_id")]
        [XmlElement("coupon_id")]
        public string CouponId { get; set; }

        /// <summary>
        /// 权益类型，可选不唯一，营销域分配
        /// </summary>
        [JsonProperty("coupon_type")]
        [XmlElement("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 权益值，可选不唯一，可能是金额（分），也可能是业务约定的其他描述
        /// </summary>
        [JsonProperty("coupon_value")]
        [XmlElement("coupon_value")]
        public string CouponValue { get; set; }
    }
}
