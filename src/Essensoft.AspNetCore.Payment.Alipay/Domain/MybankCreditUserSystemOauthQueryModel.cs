using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditUserSystemOauthQueryModel Data Structure.
    /// </summary>
    public class MybankCreditUserSystemOauthQueryModel : AlipayObject
    {
        /// <summary>
        /// 授权码，用户对应用授权后得到。
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 值为authorization_code时，代表用code换取；值为refresh_token时，代表用refresh_token换取
        /// </summary>
        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; }

        /// <summary>
        /// 刷新令牌，上次换取访问令牌时得到。见出参的refresh_token字段
        /// </summary>
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }
    }
}
