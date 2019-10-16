using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusRoute Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusRoute : AlipayObject
    {
        /// <summary>
        /// 修改类型
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// 线路方向：枚举 up  down
        /// </summary>
        [JsonProperty("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 路线id
        /// </summary>
        [JsonProperty("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 公交路线轨迹
        /// </summary>
        [JsonProperty("line_lon_lat")]
        public List<CloudbusLocation> LineLonLat { get; set; }

        /// <summary>
        /// 线路名称(87 路-上行)
        /// </summary>
        [JsonProperty("line_name")]
        public string LineName { get; set; }

        /// <summary>
        /// 运营时间
        /// </summary>
        [JsonProperty("operation_time")]
        public List<string> OperationTime { get; set; }

        /// <summary>
        /// 票价
        /// </summary>
        [JsonProperty("price")]
        public long Price { get; set; }

        /// <summary>
        /// 站点
        /// </summary>
        [JsonProperty("stops")]
        public List<CloudbusStop> Stops { get; set; }
    }
}
