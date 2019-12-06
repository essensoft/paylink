using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySystemOauthTokenResponse.
    /// </summary>
    public class AlipaySystemOauthTokenResponse : AlipayResponse
    {
        /// <summary>
        /// 访问令牌。通过该令牌调用需要授权类接口
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 已废弃，请勿使用
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 令牌类型，permanent表示返回的access_token和refresh_token永久有效，非永久令牌不返回该字段
        /// </summary>
        [JsonPropertyName("auth_token_type")]
        public string AuthTokenType { get; set; }

        /// <summary>
        /// 访问令牌的有效时间，单位是秒。
        /// </summary>
        [JsonPropertyName("expires_in")]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// 刷新令牌的有效时间，单位是秒。
        /// </summary>
        [JsonPropertyName("re_expires_in")]
        public string ReExpiresIn { get; set; }

        /// <summary>
        /// 刷新令牌。通过该令牌可以刷新access_token
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// 支付宝用户的唯一userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
