using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsMktCouponConfigDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InsMktCouponConfigDTO : AlipayObject
    {
        /// <summary>
        /// 权益配置Id
        /// </summary>
        [JsonProperty("coupon_conf_id")]
        [XmlElement("coupon_conf_id")]
        public string CouponConfId { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [JsonProperty("coupon_type")]
        [XmlElement("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 200元优惠券
        /// </summary>
        [JsonProperty("coupon_value")]
        [XmlElement("coupon_value")]
        public string CouponValue { get; set; }

        /// <summary>
        /// 核销结束时间
        /// </summary>
        [JsonProperty("use_end_time")]
        [XmlElement("use_end_time")]
        public string UseEndTime { get; set; }

        /// <summary>
        /// 核销使用规则
        /// </summary>
        [JsonProperty("use_rule")]
        [XmlElement("use_rule")]
        public string UseRule { get; set; }

        /// <summary>
        /// 核销开始时间
        /// </summary>
        [JsonProperty("use_start_time")]
        [XmlElement("use_start_time")]
        public string UseStartTime { get; set; }
    }
}
