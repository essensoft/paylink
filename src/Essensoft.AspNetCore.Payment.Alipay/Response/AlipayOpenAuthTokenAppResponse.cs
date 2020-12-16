using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAuthTokenAppResponse.
    /// </summary>
    public class AlipayOpenAuthTokenAppResponse : AlipayResponse
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
        /// 授权商户的appid
        /// </summary>
        [JsonPropertyName("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 该字段已作废，应用令牌长期有效，接入方不需要消费该字段
        /// </summary>
        [JsonPropertyName("expires_in")]
        public string ExpiresIn { get; set; }

        /// <summary>
        /// 刷新令牌的有效时间（从接口调用时间作为起始时间），单位到秒
        /// </summary>
        [JsonPropertyName("re_expires_in")]
        public string ReExpiresIn { get; set; }

        /// <summary>
        /// 批量授权换码访问令牌列表
        /// </summary>
        [JsonPropertyName("tokens")]
        public List<AppTokenExchangeSubElement> Tokens { get; set; }

        /// <summary>
        /// 授权商户的user_id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
