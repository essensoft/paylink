using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InputScheduleTime Data Structure.
    /// </summary>
    public class InputScheduleTime : AlipayObject
    {
        /// <summary>
        /// 车容量
        /// </summary>
        [JsonPropertyName("capacity")]
        public long Capacity { get; set; }

        /// <summary>
        /// 方向，参考方向枚举
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 预设车次数
        /// </summary>
        [JsonPropertyName("exp_trip_cnt")]
        public long ExpTripCnt { get; set; }

        /// <summary>
        /// 拓展参数
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [JsonPropertyName("line_id")]
        public string LineId { get; set; }
    }
}
