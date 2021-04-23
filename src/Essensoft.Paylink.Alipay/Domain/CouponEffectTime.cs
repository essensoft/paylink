using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CouponEffectTime Data Structure.
    /// </summary>
    public class CouponEffectTime : AlipayObject
    {
        /// <summary>
        /// 说明:当coupon_available_period_type不为空的时候且为ABSOLUTELY时，此处会有值  绝对时间情况下，红包发放开始时间
        /// </summary>
        [JsonPropertyName("coupon_absolutely_begin_time")]
        public string CouponAbsolutelyBeginTime { get; set; }

        /// <summary>
        /// 说明:当coupon_available_period_type不为空的时候且为ABSOLUTELY时，此处会有值  绝对时间下红包发放结束时间
        /// </summary>
        [JsonPropertyName("coupon_absolutely_end_time")]
        public string CouponAbsolutelyEndTime { get; set; }

        /// <summary>
        /// 时间周期类型 ABSOLUTELY:绝对时间 RELATIVE:相对时间
        /// </summary>
        [JsonPropertyName("coupon_available_period_type")]
        public string CouponAvailablePeriodType { get; set; }

        /// <summary>
        /// 说明:当coupon_available_period_type不为空的时候且为RELATIVE时，此处会有值  相对时间情况下，红包发放开始时间周期类型 DAYS:天级 MINUTES:分钟级
        /// </summary>
        [JsonPropertyName("coupon_relative_begin_rounding_type")]
        public string CouponRelativeBeginRoundingType { get; set; }

        /// <summary>
        /// 说明:当coupon_available_period_type不为空的时候且为RELATIVE时，此处会有值  相对时间情况下，红包开始时间相对值， 比如: coupon_relative_begin_rounding_type=DAYS coupon_relative_begin_value=1 代表次日凌晨开始生效  比如: coupon_relative_begin_rounding_type=MINUTES coupon_relative_begin_value=100 代表当前时间100分钟后开始生效
        /// </summary>
        [JsonPropertyName("coupon_relative_begin_value")]
        public long CouponRelativeBeginValue { get; set; }

        /// <summary>
        /// 说明:当coupon_available_period_type不为空的时候且为RELATIVE时，此处会有值  相对时间情况下，红包发放结束时间周期类型 DAYS:天级 MINUTES:分钟级
        /// </summary>
        [JsonPropertyName("coupon_relative_end_rounding_type")]
        public string CouponRelativeEndRoundingType { get; set; }

        /// <summary>
        /// 说明:当coupon_available_period_type不为空的时候且为RELATIVE时，此处会有值  相对时间情况下，红包开始时间相对值， 比如: coupon_relative_end_rounding_type=MINUTES coupon_relative_end_value=100 代表从生效时间开始，有效期持续为100分钟
        /// </summary>
        [JsonPropertyName("coupon_relative_end_value")]
        public long CouponRelativeEndValue { get; set; }
    }
}
