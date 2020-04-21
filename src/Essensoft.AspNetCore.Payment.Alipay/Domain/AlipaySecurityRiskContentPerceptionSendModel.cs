using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskContentPerceptionSendModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskContentPerceptionSendModel : AlipayObject
    {
        /// <summary>
        /// 业务时间。日期格式化后的字符串。
        /// </summary>
        [JsonPropertyName("business_time")]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 创建时间。日期格式化后的字符串，和business_time区分，标识计算引擎得出指标的时间。
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 持续时间。单位默认1min。
        /// </summary>
        [JsonPropertyName("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 风险感知度量的键
        /// </summary>
        [JsonPropertyName("metric")]
        public string Metric { get; set; }

        /// <summary>
        /// 风险感知度量的值。对应为metric的值。通常是一个可解析的json串。
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
