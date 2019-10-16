using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusRouteRItem Data Structure.
    /// </summary>
    [Serializable]
    public class CloudbusRouteRItem : AlipayObject
    {
        /// <summary>
        /// 线路变更后结果
        /// </summary>
        [JsonProperty("after")]
        public CloudbusPredictRItem After { get; set; }

        /// <summary>
        /// 线路变更前线路信息
        /// </summary>
        [JsonProperty("before")]
        public CloudbusPredictRItem Before { get; set; }

        /// <summary>
        /// 线路方向
        /// </summary>
        [JsonProperty("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [JsonProperty("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 线路名称(87 路-上行)
        /// </summary>
        [JsonProperty("line_name")]
        public string LineName { get; set; }
    }
}
