using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdFacePayCreateResponse.
    /// </summary>
    public class AlipaySecurityProdFacePayCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 2
        /// </summary>
        [JsonPropertyName("bbb")]
        public string Bbb { get; set; }
    }
}
