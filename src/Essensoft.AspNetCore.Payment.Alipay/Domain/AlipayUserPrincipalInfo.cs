using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserPrincipalInfo Data Structure.
    /// </summary>
    public class AlipayUserPrincipalInfo : AlipayObject
    {
        /// <summary>
        /// 用户电子邮箱
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 用户的手机号
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
