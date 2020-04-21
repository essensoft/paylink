using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OriDestOdItem Data Structure.
    /// </summary>
    public class OriDestOdItem : AlipayObject
    {
        /// <summary>
        /// 目的geohash
        /// </summary>
        [JsonPropertyName("dest_geo")]
        public string DestGeo { get; set; }

        /// <summary>
        /// od数量
        /// </summary>
        [JsonPropertyName("od")]
        public long Od { get; set; }

        /// <summary>
        /// 周末
        /// </summary>
        [JsonPropertyName("week_od")]
        public long WeekOd { get; set; }

        /// <summary>
        /// 工作日OD
        /// </summary>
        [JsonPropertyName("work_od")]
        public long WorkOd { get; set; }
    }
}
