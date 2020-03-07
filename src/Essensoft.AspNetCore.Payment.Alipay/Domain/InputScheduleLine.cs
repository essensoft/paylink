using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InputScheduleLine Data Structure.
    /// </summary>
    public class InputScheduleLine : AlipayObject
    {
        /// <summary>
        /// 方向，参考方向枚举
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 拓展参数
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 线路id
        /// </summary>
        [JsonPropertyName("line_id")]
        public string LineId { get; set; }

        /// <summary>
        /// 聚合时间粒度，单位：分钟
        /// </summary>
        [JsonPropertyName("time_span")]
        public long TimeSpan { get; set; }
    }
}
