using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthTokenAppModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthTokenAppModel : AlipayObject
    {
        /// <summary>
        /// 授权码，应用授权后得到。本参数在 grant_type 为 authorization_code 时必填；为 refresh_token 时不填。
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 授权方式。支持： authorization_code：使用应用授权码换取应用授权令牌app_auth_token。 refresh_token：使用app_refresh_token刷新获取新授权令牌。 
        /// </summary>
        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// 刷新令牌，上次换取访问令牌时得到。本参数在 grant_type 为 authorization_code 时不填；为 refresh_token 时必填，且该值来源于此接口的返回值 app_refresh_token（即至少需要通过 grant_type=authorization_code 调用此接口一次才能获取）。
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
