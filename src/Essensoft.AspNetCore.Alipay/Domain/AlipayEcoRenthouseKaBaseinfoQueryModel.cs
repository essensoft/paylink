using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseKaBaseinfoQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoRenthouseKaBaseinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// kaCode唯一标识
        /// </summary>
        [JsonProperty("ka_code")]
        public string KaCode { get; set; }
    }
}
