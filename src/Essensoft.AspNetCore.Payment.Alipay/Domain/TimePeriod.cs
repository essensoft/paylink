using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TimePeriod Data Structure.
    /// </summary>
    public class TimePeriod : AlipayObject
    {
        /// <summary>
        /// 自提时段开始时间，如05:00
        /// </summary>
        [JsonPropertyName("begin_time")]
        public string BeginTime { get; set; }

        /// <summary>
        /// 自提时段结束时间，如23:30
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }
    }
}
