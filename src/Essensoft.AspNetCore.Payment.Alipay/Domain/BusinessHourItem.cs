using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BusinessHourItem Data Structure.
    /// </summary>
    public class BusinessHourItem : AlipayObject
    {
        /// <summary>
        /// 营业结束时间，精确到分钟
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 营业开始时间，精确到分钟。
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
