using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAuthTokenAppQueryResponse.
    /// </summary>
    public class AlipayOpenAuthTokenAppQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 授权商户的appid
        /// </summary>
        [JsonPropertyName("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 授权失效时间
        /// </summary>
        [JsonPropertyName("auth_end")]
        public string AuthEnd { get; set; }

        /// <summary>
        /// 当前app_auth_token的授权接口列表
        /// </summary>
        [JsonPropertyName("auth_methods")]
        public List<string> AuthMethods { get; set; }

        /// <summary>
        /// 授权生效时间
        /// </summary>
        [JsonPropertyName("auth_start")]
        public string AuthStart { get; set; }

        /// <summary>
        /// 应用授权令牌失效时间，单位到秒
        /// </summary>
        [JsonPropertyName("expires_in")]
        public long ExpiresIn { get; set; }

        /// <summary>
        /// valid：有效状态；invalid：无效状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 授权商户的user_id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
