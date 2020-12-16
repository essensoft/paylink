using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdFacePayCreateModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdFacePayCreateModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("aaa")]
        public string Aaa { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [JsonPropertyName("aaaaaaaaaaaaa")]
        public string Aaaaaaaaaaaaa { get; set; }
    }
}
