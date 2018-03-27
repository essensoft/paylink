using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayZmScoreZrankResult Data Structure.
    /// </summary>
    public class AlipayZmScoreZrankResult : AlipayObject
    {
        /// <summary>
        /// 芝麻分分段 Z0-Z7
        /// </summary>
        [JsonProperty("zrank")]
        public string Zrank { get; set; }
    }
}
