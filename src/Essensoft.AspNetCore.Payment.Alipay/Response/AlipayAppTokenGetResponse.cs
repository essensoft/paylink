using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAppTokenGetResponse.
    /// </summary>
    public class AlipayAppTokenGetResponse : AlipayResponse
    {
        /// <summary>
        /// 应用访问令牌
        /// </summary>
        [JsonPropertyName("app_access_token")]
        public string AppAccessToken { get; set; }

        /// <summary>
        /// 应用访问凭证有效时间，单位：秒
        /// </summary>
        [JsonPropertyName("expires_in")]
        public long ExpiresIn { get; set; }
    }
}
