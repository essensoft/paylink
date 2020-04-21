using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AppTokenExchangeSubElement Data Structure.
    /// </summary>
    public class AppTokenExchangeSubElement : AlipayObject
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

        /// <summary>
        /// 授权商户appid
        /// </summary>
        [JsonPropertyName("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonPropertyName("expires_in")]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// 刷新令牌过期时间
        /// </summary>
        [JsonPropertyName("re_expires_in")]
        public string ReExpiresIn { get; set; }

        /// <summary>
        /// 授权商户的user_id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
