using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceKidsTokenCreateResponse.
    /// </summary>
    public class AlipayCommerceKidsTokenCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonPropertyName("expire_time")]
        public string ExpireTime { get; set; }

        /// <summary>
        /// token
        /// </summary>
        [JsonPropertyName("kids_token")]
        public string KidsToken { get; set; }
    }
}
