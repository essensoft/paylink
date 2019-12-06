using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ValidDateInfo Data Structure.
    /// </summary>
    public class ValidDateInfo : AlipayObject
    {
        /// <summary>
        /// 截至时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 相对有效期
        /// </summary>
        [JsonPropertyName("relative_time")]
        public PeriodInfo RelativeTime { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 时间模式,RELATIVE=相对时间，RELATIVE=绝对模式
        /// </summary>
        [JsonPropertyName("time_mode")]
        public string TimeMode { get; set; }
    }
}
