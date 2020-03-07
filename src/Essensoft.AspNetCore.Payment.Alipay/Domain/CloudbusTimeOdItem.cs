using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusTimeOdItem Data Structure.
    /// </summary>
    public class CloudbusTimeOdItem : AlipayObject
    {
        /// <summary>
        /// 公交od
        /// </summary>
        [JsonPropertyName("bus_od")]
        public long BusOd { get; set; }

        /// <summary>
        /// 潜在od
        /// </summary>
        [JsonPropertyName("od")]
        public long Od { get; set; }

        /// <summary>
        /// 时间，精确到小时
        /// </summary>
        [JsonPropertyName("time")]
        public string Time { get; set; }

        /// <summary>
        /// 工作日od
        /// </summary>
        [JsonPropertyName("week_od")]
        public long WeekOd { get; set; }

        /// <summary>
        /// 工作日od
        /// </summary>
        [JsonPropertyName("work_od")]
        public long WorkOd { get; set; }
    }
}
