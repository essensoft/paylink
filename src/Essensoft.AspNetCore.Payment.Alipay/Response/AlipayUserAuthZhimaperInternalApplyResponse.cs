using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAuthZhimaperInternalApplyResponse.
    /// </summary>
    public class AlipayUserAuthZhimaperInternalApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 访问令牌。通过该令牌调用需要授权类接口
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// 令牌类型，permanent表示返回的access_token和refresh_token永久有效，不受expires_in和re_expires_in限制，默认是空，即受expires_in和re_expires_in限制的时效性令牌
        /// </summary>
        [JsonPropertyName("auth_token_type")]
        public string AuthTokenType { get; set; }

        /// <summary>
        /// 刷新令牌。通过该令牌可以刷新access_token
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
