using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ScheduleWorkItems Data Structure.
    /// </summary>
    public class ScheduleWorkItems : AlipayObject
    {
        /// <summary>
        /// 统计
        /// </summary>
        [JsonPropertyName("stats")]
        public List<ScheduleWorkStatItem> Stats { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("work")]
        public List<ScheduleWorkItem> Work { get; set; }
    }
}
