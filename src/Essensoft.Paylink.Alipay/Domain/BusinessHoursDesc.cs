using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BusinessHoursDesc Data Structure.
    /// </summary>
    public class BusinessHoursDesc : AlipayObject
    {
        /// <summary>
        /// 一周中的哪几天
        /// </summary>
        [JsonPropertyName("days_in_week")]
        public List<long> DaysInWeek { get; set; }

        /// <summary>
        /// 一天中的时间，24小时制
        /// </summary>
        [JsonPropertyName("hours")]
        public string Hours { get; set; }
    }
}
