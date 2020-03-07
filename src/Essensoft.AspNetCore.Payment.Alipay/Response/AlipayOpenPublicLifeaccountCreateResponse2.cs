using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeaccountCreateResponse.
    /// </summary>
    public class AlipayOpenPublicLifeaccountCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 生活号id
        /// </summary>
        [JsonPropertyName("public_id")]
        public string PublicId { get; set; }

        /// <summary>
        /// 是否是重试请求
        /// </summary>
        [JsonPropertyName("retry")]
        public bool Retry { get; set; }
    }
}
