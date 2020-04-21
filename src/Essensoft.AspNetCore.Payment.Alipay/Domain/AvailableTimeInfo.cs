using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AvailableTimeInfo Data Structure.
    /// </summary>
    public class AvailableTimeInfo : AlipayObject
    {
        /// <summary>
        /// limit_period_unit为WEEK_DAY，周范围内日单位[1,7]，limit_period_unit 为DAY，月范围内日单位[1,31]
        /// </summary>
        [JsonPropertyName("available_days")]
        public List<long> AvailableDays { get; set; }

        /// <summary>
        /// 开始时间如 13:00  代表下午1点
        /// </summary>
        [JsonPropertyName("from_time")]
        public string FromTime { get; set; }

        /// <summary>
        /// WEEK_DAY, "周范围内日单位[1,7]， DAY, "月范围内日单位[1,31]
        /// </summary>
        [JsonPropertyName("limit_period_unit")]
        public string LimitPeriodUnit { get; set; }

        /// <summary>
        /// 结束时间 如 14:10  代表下午2点10分
        /// </summary>
        [JsonPropertyName("to_time")]
        public string ToTime { get; set; }
    }
}
