using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusPredictRItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusPredictRItem : AlipayObject
    {
        /// <summary>
        /// 站点轨迹
        /// </summary>
        [JsonProperty("line_lon_lat")]
        public List<CloudbusLocation> LineLonLat { get; set; }

        /// <summary>
        /// 运营时间
        /// </summary>
        [JsonProperty("operation_time")]
        public List<string> OperationTime { get; set; }

        /// <summary>
        /// 线路总客流
        /// </summary>
        [JsonProperty("route_volume")]
        public long RouteVolume { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [JsonProperty("stops")]
        public List<CloudbusStop> Stops { get; set; }
    }
}
