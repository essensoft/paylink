using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdUmidQueryResponse.
    /// </summary>
    public class AlipaySecurityProdUmidQueryResponse : AlipayResponse
    {
        /// <summary>
        /// umid:客户端对应的UMID值，从UMID系统获取。
        /// </summary>
        [JsonPropertyName("umid")]
        public string Umid { get; set; }
    }
}
