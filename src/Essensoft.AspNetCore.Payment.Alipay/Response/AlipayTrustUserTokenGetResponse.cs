using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTrustUserTokenGetResponse.
    /// </summary>
    public class AlipayTrustUserTokenGetResponse : AlipayResponse
    {
        /// <summary>
        /// 访问令牌
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 本字段已废弃
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
