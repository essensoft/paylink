using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BaseOpenApiResponseHeaderDTO Data Structure.
    /// </summary>
    public class BaseOpenApiResponseHeaderDTO : AlipayObject
    {
        /// <summary>
        /// http状态码
        /// </summary>
        [JsonPropertyName("status_code")]
        public string StatusCode { get; set; }
    }
}
