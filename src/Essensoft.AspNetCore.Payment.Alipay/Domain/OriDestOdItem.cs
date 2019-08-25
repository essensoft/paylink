using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OriDestOdItem Data Structure.
    /// </summary>
    [Serializable]
    public class OriDestOdItem : AlipayObject
    {
        /// <summary>
        /// 目的geohash
        /// </summary>
        [JsonProperty("dest_geo")]
        public string DestGeo { get; set; }

        /// <summary>
        /// od数量
        /// </summary>
        [JsonProperty("od")]
        public long Od { get; set; }

        /// <summary>
        /// 周末
        /// </summary>
        [JsonProperty("week_od")]
        public long WeekOd { get; set; }

        /// <summary>
        /// 工作日OD
        /// </summary>
        [JsonProperty("work_od")]
        public long WorkOd { get; set; }
    }
}
