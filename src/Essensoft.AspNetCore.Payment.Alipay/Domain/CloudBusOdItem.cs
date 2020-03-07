using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudBusOdItem Data Structure.
    /// </summary>
    public class CloudBusOdItem : AlipayObject
    {
        /// <summary>
        /// 实际公交od值
        /// </summary>
        [JsonPropertyName("bus_od")]
        public long BusOd { get; set; }

        /// <summary>
        /// geo hash
        /// </summary>
        [JsonPropertyName("dest_geohash")]
        public string DestGeohash { get; set; }

        /// <summary>
        /// 潜在od值
        /// </summary>
        [JsonPropertyName("od")]
        public long Od { get; set; }

        /// <summary>
        /// 非工作日od日均
        /// </summary>
        [JsonPropertyName("week_od")]
        public long WeekOd { get; set; }

        /// <summary>
        /// 工作日od日均
        /// </summary>
        [JsonPropertyName("work_od")]
        public long WorkOd { get; set; }
    }
}
