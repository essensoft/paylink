using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditUserInfoShareQueryModel Data Structure.
    /// </summary>
    public class MybankCreditUserInfoShareQueryModel : AlipayObject
    {
        /// <summary>
        /// 访问令牌。通过该令牌调用需要授权类接口. mybank.credit.user.system.oauth.query接口返回
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }
    }
}
