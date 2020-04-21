using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CrowdRuleInfo Data Structure.
    /// </summary>
    public class CrowdRuleInfo : AlipayObject
    {
        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonPropertyName("ruledesc")]
        public string Ruledesc { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [JsonPropertyName("ruleid")]
        public string Ruleid { get; set; }

        /// <summary>
        /// 圈人规则的状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
