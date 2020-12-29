using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishPeriodExtendInfo Data Structure.
    /// </summary>
    public class KbdishPeriodExtendInfo : AlipayObject
    {
        /// <summary>
        /// 结束日期
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 起始日期
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 时间段规则
        /// </summary>
        [JsonPropertyName("time_range_list")]
        public List<KbdishTimeRangeInfo> TimeRangeList { get; set; }

        /// <summary>
        /// 周规则(1-7数字，用逗号隔开)
        /// </summary>
        [JsonPropertyName("weeks")]
        public string Weeks { get; set; }
    }
}
