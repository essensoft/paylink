using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppXwbsssQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppXwbsssQueryModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("a")]
        public string A { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("b")]
        public string B { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("c")]
        public List<long> C { get; set; }

        /// <summary>
        /// 描述描述描述描述
        /// </summary>
        [JsonPropertyName("effect_date")]
        public string EffectDate { get; set; }
    }
}
