using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudBusOdItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudBusOdItem : AlipayObject
    {
        /// <summary>
        /// 实际公交od值
        /// </summary>
        [JsonProperty("bus_od")]
        public long BusOd { get; set; }

        /// <summary>
        /// geo hash
        /// </summary>
        [JsonProperty("dest_geohash")]
        public string DestGeohash { get; set; }

        /// <summary>
        /// 潜在od值
        /// </summary>
        [JsonProperty("od")]
        public long Od { get; set; }

        /// <summary>
        /// 非工作日od日均
        /// </summary>
        [JsonProperty("week_od")]
        public long WeekOd { get; set; }

        /// <summary>
        /// 工作日od日均
        /// </summary>
        [JsonProperty("work_od")]
        public long WorkOd { get; set; }
    }
}
