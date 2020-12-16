using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdFacePayModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdFacePayModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("a")]
        public string A { get; set; }
    }
}
