using System.Text.Json.Serialization;

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
        [JsonPropertyName("safe_domain")]
        public string SafeDomain { get; set; }
    }
}
