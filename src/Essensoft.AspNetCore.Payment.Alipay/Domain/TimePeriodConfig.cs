using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TimePeriodConfig Data Structure.
    /// </summary>
    public class TimePeriodConfig : AlipayObject
    {
        /// <summary>
        /// 自提时段列表，包含时段开始时间和结束时间
        /// </summary>
        [JsonPropertyName("time_period_list")]
        public List<TimePeriod> TimePeriodList { get; set; }

        /// <summary>
        /// 1-7分别表示周一到周日
        /// </summary>
        [JsonPropertyName("week")]
        public string Week { get; set; }
    }
}
