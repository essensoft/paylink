using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsMktCouponConfigDTO Data Structure.
    /// </summary>
    public class InsMktCouponConfigDTO : AlipayObject
    {
        /// <summary>
        /// 权益配置Id
        /// </summary>
        [JsonPropertyName("coupon_conf_id")]
        public string CouponConfId { get; set; }

        /// <summary>
        /// 权益类型
        /// </summary>
        [JsonPropertyName("coupon_type")]
        public string CouponType { get; set; }

        /// <summary>
        /// 200元优惠券
        /// </summary>
        [JsonPropertyName("coupon_value")]
        public string CouponValue { get; set; }

        /// <summary>
        /// 核销结束时间
        /// </summary>
        [JsonPropertyName("use_end_time")]
        public string UseEndTime { get; set; }

        /// <summary>
        /// 核销使用规则
        /// </summary>
        [JsonPropertyName("use_rule")]
        public string UseRule { get; set; }

        /// <summary>
        /// 核销开始时间
        /// </summary>
        [JsonPropertyName("use_start_time")]
        public string UseStartTime { get; set; }
    }
}
