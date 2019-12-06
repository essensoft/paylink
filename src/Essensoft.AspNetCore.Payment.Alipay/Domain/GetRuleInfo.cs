using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GetRuleInfo Data Structure.
    /// </summary>
    public class GetRuleInfo : AlipayObject
    {
        /// <summary>
        /// 截至时间
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 发放次数限制
        /// </summary>
        [JsonPropertyName("get_count_limit")]
        public PeriodInfo GetCountLimit { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
