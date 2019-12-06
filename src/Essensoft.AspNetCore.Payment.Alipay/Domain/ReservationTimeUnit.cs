using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ReservationTimeUnit Data Structure.
    /// </summary>
    public class ReservationTimeUnit : AlipayObject
    {
        /// <summary>
        /// 时间，格式HH:mm
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; }

        /// <summary>
        /// 当日CURRENT_DAY  次日NEXT_DAY
        /// </summary>
        [JsonPropertyName("time_type")]
        public string TimeType { get; set; }
    }
}
