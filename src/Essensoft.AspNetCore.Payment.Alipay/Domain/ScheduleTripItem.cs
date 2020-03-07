using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ScheduleTripItem Data Structure.
    /// </summary>
    public class ScheduleTripItem : AlipayObject
    {
        /// <summary>
        /// 方向，参考方向枚举
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [JsonPropertyName("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 单程行驶时间(单位min)
        /// </summary>
        [JsonPropertyName("run_time")]
        public long RunTime { get; set; }

        /// <summary>
        /// 若time_span为10，则06:00表示06:00-06:10的时段； 若time_span为30，则06:00表示06:00-06:30的时段
        /// </summary>
        [JsonPropertyName("time_period")]
        public string TimePeriod { get; set; }
    }
}
