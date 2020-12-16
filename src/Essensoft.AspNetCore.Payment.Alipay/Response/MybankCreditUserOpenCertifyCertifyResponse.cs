using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditUserOpenCertifyCertifyResponse.
    /// </summary>
    public class MybankCreditUserOpenCertifyCertifyResponse : AlipayResponse
    {
        /// <summary>
        /// auth_url
        /// </summary>
        [JsonPropertyName("auth_url")]
        public string AuthUrl { get; set; }
    }
}
