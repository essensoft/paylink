using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MetroOdItem Data Structure.
    /// </summary>
    public class MetroOdItem : AlipayObject
    {
        /// <summary>
        /// D
        /// </summary>
        [JsonPropertyName("dest_geo")]
        public string DestGeo { get; set; }

        /// <summary>
        /// 客流
        /// </summary>
        [JsonPropertyName("od")]
        public long Od { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        [JsonPropertyName("time")]
        public long Time { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonPropertyName("user_info")]
        public CloudbusUserInfo UserInfo { get; set; }

        /// <summary>
        /// 周末客流
        /// </summary>
        [JsonPropertyName("week_od")]
        public long WeekOd { get; set; }

        /// <summary>
        /// 工作日客流
        /// </summary>
        [JsonPropertyName("work_od")]
        public long WorkOd { get; set; }
    }
}
