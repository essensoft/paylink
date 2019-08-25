using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CrowdRuleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CrowdRuleInfo : AlipayObject
    {
        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("ruledesc")]
        public string Ruledesc { get; set; }

        /// <summary>
        /// 规则id
        /// </summary>
        [JsonProperty("ruleid")]
        public string Ruleid { get; set; }

        /// <summary>
        /// 圈人规则的状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
