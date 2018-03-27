using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniSafedomainDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniSafedomainDeleteModel : AlipayObject
    {
        /// <summary>
        /// httpRequest域白名单
        /// </summary>
        [JsonProperty("safe_domain")]
        public string SafeDomain { get; set; }
    }
}
