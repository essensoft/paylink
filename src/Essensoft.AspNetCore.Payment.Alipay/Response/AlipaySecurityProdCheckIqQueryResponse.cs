using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdCheckIqQueryResponse.
    /// </summary>
    public class AlipaySecurityProdCheckIqQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("a")]
        public string A { get; set; }
    }
}
