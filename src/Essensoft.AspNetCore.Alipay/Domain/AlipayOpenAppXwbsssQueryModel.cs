using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppXwbsssQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppXwbsssQueryModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("a")]
        public string A { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("b")]
        public string B { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("c")]
        public List<long> C { get; set; }

        /// <summary>
        /// 描述描述描述描述
        /// </summary>
        [JsonProperty("effect_date")]
        public string EffectDate { get; set; }
    }
}
