using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TimePeriodRule Data Structure.
    /// </summary>
    public class TimePeriodRule : AlipayObject
    {
        /// <summary>
        /// 结束时间， 格式HH:mm:ss
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// (1)如果rule_type=day，则格式为表示具体日期yyyy-MM-dd且逗号分隔的字符串. 例：2019-09-09,2019-10-10 表示具体这两天;  (2)如果rule_type=week，则格式为表示星期几的1-7的数字且逗号分隔的字符串. 例：1,2,4 表示周一周二周四
        /// </summary>
        [JsonPropertyName("rule_info")]
        public List<string> RuleInfo { get; set; }

        /// <summary>
        /// 时间类型; 天：day,  周：week
        /// </summary>
        [JsonPropertyName("rule_type")]
        public string RuleType { get; set; }

        /// <summary>
        /// 开始时间, 格式HH:mm:ss
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
