using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SingleTripDurationQueryOpenapiResult Data Structure.
    /// </summary>
    public class SingleTripDurationQueryOpenapiResult : AlipayObject
    {
        /// <summary>
        /// 线路方向（UP-上行，DOWN-下行）
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 结束时刻（hh24:mi:ss）
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展信息，json格式，由双方约定取值
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 线路ID，同一条线路的不同方向该值不同
        /// </summary>
        [JsonPropertyName("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 线路Key，同一条线路的不同方向该值相同
        /// </summary>
        [JsonPropertyName("line_key")]
        public string LineKey { get; set; }

        /// <summary>
        /// 单程行驶时间，单位：分钟
        /// </summary>
        [JsonPropertyName("single_trip_duration")]
        public long SingleTripDuration { get; set; }

        /// <summary>
        /// 开始时刻（hh24:mi:ss）
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
