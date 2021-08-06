using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SearchProductPeriod Data Structure.
    /// </summary>
    public class SearchProductPeriod : AlipayObject
    {
        /// <summary>
        /// 结束作用日期
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 开始作用日期
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 作用时间区间，e.g. HH:mm-HH:mm-标识
        /// </summary>
        [JsonPropertyName("working_hours")]
        public List<string> WorkingHours { get; set; }

        /// <summary>
        /// 作用一周的星期数
        /// </summary>
        [JsonPropertyName("working_weekdays")]
        public List<string> WorkingWeekdays { get; set; }
    }
}
