using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OdAnalysisLineInfo Data Structure.
    /// </summary>
    public class OdAnalysisLineInfo : AlipayObject
    {
        /// <summary>
        /// 线路方向（UP-上行，DOWN-下行）
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 线路ID，同一条线路的不同方向该值不同
        /// </summary>
        [JsonPropertyName("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 线路Key，同一条线路的不同方向该值相同
        /// </summary>
        [JsonPropertyName("line_key")]
        public string LineKey { get; set; }

        /// <summary>
        /// 聚合时间粒度，单位：分钟，只支持30/60
        /// </summary>
        [JsonPropertyName("time_span")]
        public long TimeSpan { get; set; }
    }
}
