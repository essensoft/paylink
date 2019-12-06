using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudbusRouteRItem Data Structure.
    /// </summary>
    public class CloudbusRouteRItem : AlipayObject
    {
        /// <summary>
        /// 线路变更后结果
        /// </summary>
        [JsonPropertyName("after")]
        public CloudbusPredictRItem After { get; set; }

        /// <summary>
        /// 线路变更前线路信息
        /// </summary>
        [JsonPropertyName("before")]
        public CloudbusPredictRItem Before { get; set; }

        /// <summary>
        /// 线路方向
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [JsonPropertyName("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 线路名称(87 路-上行)
        /// </summary>
        [JsonPropertyName("line_name")]
        public string LineName { get; set; }
    }
}
