using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusTimeOdItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusTimeOdItem : AlipayObject
    {
        /// <summary>
        /// 公交od
        /// </summary>
        [JsonProperty("bus_od")]
        public long BusOd { get; set; }

        /// <summary>
        /// 潜在od
        /// </summary>
        [JsonProperty("od")]
        public long Od { get; set; }

        /// <summary>
        /// 时间，精确到小时
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }

        /// <summary>
        /// 工作日od
        /// </summary>
        [JsonProperty("week_od")]
        public long WeekOd { get; set; }

        /// <summary>
        /// 工作日od
        /// </summary>
        [JsonProperty("work_od")]
        public long WorkOd { get; set; }
    }
}
