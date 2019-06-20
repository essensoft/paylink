using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsOption Data Structure.
    /// </summary>
    [Serializable]
    public class InsOption : AlipayObject
    {
        /// <summary>
        /// 保额key
        /// </summary>
        [JsonProperty("coverage")]
        public string Coverage { get; set; }

        /// <summary>
        /// 保额value
        /// </summary>
        [JsonProperty("coverage_text")]
        public string CoverageText { get; set; }
    }
}
