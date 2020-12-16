using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PrizeValidPeriod Data Structure.
    /// </summary>
    public class PrizeValidPeriod : AlipayObject
    {
        /// <summary>
        /// 使用生效相对分钟数（相对时间）
        /// </summary>
        [JsonPropertyName("active_min")]
        public long ActiveMin { get; set; }

        /// <summary>
        /// 废弃
        /// </summary>
        [JsonPropertyName("active_mins")]
        public string ActiveMins { get; set; }

        /// <summary>
        /// 使用开始时间（绝对时间
        /// </summary>
        [JsonPropertyName("active_time")]
        public string ActiveTime { get; set; }

        /// <summary>
        /// 使用截止相对分钟数（相对时间）
        /// </summary>
        [JsonPropertyName("end_min")]
        public long EndMin { get; set; }

        /// <summary>
        /// 废弃
        /// </summary>
        [JsonPropertyName("end_mins")]
        public string EndMins { get; set; }

        /// <summary>
        /// 使用截止时间（绝对时间）
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// RELATIVE->相对时间 ABSOLUTE->绝对时间
        /// </summary>
        [JsonPropertyName("period_type")]
        public string PeriodType { get; set; }
    }
}
