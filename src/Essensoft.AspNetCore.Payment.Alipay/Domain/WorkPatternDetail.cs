using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WorkPatternDetail Data Structure.
    /// </summary>
    public class WorkPatternDetail : AlipayObject
    {
        /// <summary>
        /// 结束时刻（hh24:mi:ss）
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 营运车次数
        /// </summary>
        [JsonPropertyName("service_trip_count")]
        public long ServiceTripCount { get; set; }

        /// <summary>
        /// 开始时刻（hh24:mi:ss）
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
