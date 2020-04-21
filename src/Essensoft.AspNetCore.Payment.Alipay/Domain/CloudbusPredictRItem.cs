using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusPredictRItem Data Structure.
    /// </summary>
    public class CloudbusPredictRItem : AlipayObject
    {
        /// <summary>
        /// 站点轨迹
        /// </summary>
        [JsonPropertyName("line_lon_lat")]
        public List<CloudbusLocation> LineLonLat { get; set; }

        /// <summary>
        /// 运营时间
        /// </summary>
        [JsonPropertyName("operation_time")]
        public List<string> OperationTime { get; set; }

        /// <summary>
        /// 线路总客流
        /// </summary>
        [JsonPropertyName("route_volume")]
        public long RouteVolume { get; set; }

        /// <summary>
        /// 11
        /// </summary>
        [JsonPropertyName("stops")]
        public List<CloudbusStop> Stops { get; set; }
    }
}
