using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FrequencyRuleDetail Data Structure.
    /// </summary>
    public class FrequencyRuleDetail : AlipayObject
    {
        /// <summary>
        /// 频次单位数量，2月1次，则frequencyDuration为2，totalTimes为1，frequencyType为MONTH
        /// </summary>
        [JsonPropertyName("frequency_duration")]
        public string FrequencyDuration { get; set; }

        /// <summary>
        /// 频次类型：DAY-自然日频次，MONTH-自然月频次，INFINITE-永久频次
        /// </summary>
        [JsonPropertyName("frequency_type")]
        public string FrequencyType { get; set; }

        /// <summary>
        /// 总次数
        /// </summary>
        [JsonPropertyName("total_times")]
        public long TotalTimes { get; set; }

        /// <summary>
        /// 已使用次数
        /// </summary>
        [JsonPropertyName("used_times")]
        public long UsedTimes { get; set; }
    }
}
