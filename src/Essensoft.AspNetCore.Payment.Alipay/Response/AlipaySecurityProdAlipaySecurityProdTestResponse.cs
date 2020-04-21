using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdAlipaySecurityProdTestResponse.
    /// </summary>
    public class AlipaySecurityProdAlipaySecurityProdTestResponse : AlipayResponse
    {
        /// <summary>
        /// ddd
        /// </summary>
        [JsonPropertyName("admin")]
        public string Admin { get; set; }
    }
}
