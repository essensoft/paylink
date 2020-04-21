using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserProfileDetail Data Structure.
    /// </summary>
    public class UserProfileDetail : AlipayObject
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户发行主体;  ALIPAY:支付宝,TAOBAO:淘宝,MERCHANT:商户(星巴克)
        /// </summary>
        [JsonPropertyName("user_issuer")]
        public string UserIssuer { get; set; }
    }
}
