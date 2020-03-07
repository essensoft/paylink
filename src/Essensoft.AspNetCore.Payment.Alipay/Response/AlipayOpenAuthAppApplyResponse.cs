using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAuthAppApplyResponse.
    /// </summary>
    public class AlipayOpenAuthAppApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 应用授权令牌
        /// </summary>
        [JsonPropertyName("app_auth_token")]
        public string AppAuthToken { get; set; }

        /// <summary>
        /// 刷新令牌
        /// </summary>
        [JsonPropertyName("app_refresh_token")]
        public string AppRefreshToken { get; set; }
    }
}
