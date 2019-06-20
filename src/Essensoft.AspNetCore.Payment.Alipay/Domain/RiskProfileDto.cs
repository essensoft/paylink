using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RiskProfileDto Data Structure.
    /// </summary>
    [Serializable]
    public class RiskProfileDto : AlipayObject
    {
        /// <summary>
        /// risk profile名称和入参对应
        /// </summary>
        [JsonProperty("risk_profile")]
        public string RiskProfile { get; set; }

        /// <summary>
        /// risk profile对应主体的分值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
