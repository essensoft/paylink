using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusRoute Data Structure.
    /// </summary>
    public class CloudbusRoute : AlipayObject
    {
        /// <summary>
        /// 修改类型
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 线路方向：枚举 up  down
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 路线id
        /// </summary>
        [JsonPropertyName("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 公交路线轨迹
        /// </summary>
        [JsonPropertyName("line_lon_lat")]
        public List<CloudbusLocation> LineLonLat { get; set; }

        /// <summary>
        /// 线路名称(87 路-上行)
        /// </summary>
        [JsonPropertyName("line_name")]
        public string LineName { get; set; }

        /// <summary>
        /// 运营时间
        /// </summary>
        [JsonPropertyName("operation_time")]
        public List<string> OperationTime { get; set; }

        /// <summary>
        /// 票价
        /// </summary>
        [JsonPropertyName("price")]
        public long Price { get; set; }

        /// <summary>
        /// 站点
        /// </summary>
        [JsonPropertyName("stops")]
        public List<CloudbusStop> Stops { get; set; }
    }
}
