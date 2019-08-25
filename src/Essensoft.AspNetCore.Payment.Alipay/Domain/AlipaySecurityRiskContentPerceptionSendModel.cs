using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskContentPerceptionSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskContentPerceptionSendModel : AlipayObject
    {
        /// <summary>
        /// 业务时间。日期格式化后的字符串。
        /// </summary>
        [JsonProperty("business_time")]
        public string BusinessTime { get; set; }

        /// <summary>
        /// 创建时间。日期格式化后的字符串，和business_time区分，标识计算引擎得出指标的时间。
        /// </summary>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 持续时间。单位默认1min。
        /// </summary>
        [JsonProperty("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 风险感知度量的键
        /// </summary>
        [JsonProperty("metric")]
        public string Metric { get; set; }

        /// <summary>
        /// 风险感知度量的值。对应为metric的值。通常是一个可解析的json串。
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
