using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MEquityValidInfo Data Structure.
    /// </summary>
    public class MEquityValidInfo : AlipayObject
    {
        /// <summary>
        /// 延迟生效时间(单位分钟)；延迟生效时间取值范围1~99999的整数，注意：仅当effect_type=DELAY时，该值起作用
        /// </summary>
        [JsonPropertyName("delay_minutes")]
        public long DelayMinutes { get; set; }

        /// <summary>
        /// 券生效方式，当券有效期为绝对时间（FIXED）时，只能设置IMMEDIATELY，枚举取值：立即生效：IMMEDIATELY，延迟生效：DELAY
        /// </summary>
        [JsonPropertyName("effect_type")]
        public string EffectType { get; set; }

        /// <summary>
        /// 权益结束时间，有效期类型valid_type为FIXED绝对方式时必填且仅当FIXED类型，该值可用，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 描述了券相对领取后多少分钟有效，取值必须1~99999的整数，有效期类型valid_type为RELATIVE时必填且仅当RELATIVE值时该值起作用
        /// </summary>
        [JsonPropertyName("relative_minutes")]
        public long RelativeMinutes { get; set; }

        /// <summary>
        /// 权益开始时间，有效期类型valid_type为FIXED绝对方式时必填且仅当FIXED类型，该值可用，格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 有效期类型，支持枚举值：绝对方式：FIXED、相对方式：RELATIVE
        /// </summary>
        [JsonPropertyName("valid_type")]
        public string ValidType { get; set; }
    }
}
