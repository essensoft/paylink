using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditUserSystemOauthQueryResponse.
    /// </summary>
    public class MybankCreditUserSystemOauthQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 访问令牌。通过该令牌调用需要授权类接口
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

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
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
