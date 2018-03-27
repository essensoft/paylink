using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniSafedomainCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniSafedomainCreateModel : AlipayObject
    {
        /// <summary>
        /// httpRequest域白名单
        /// </summary>
        [JsonProperty("safe_domain")]
        public string SafeDomain { get; set; }
    }
}
