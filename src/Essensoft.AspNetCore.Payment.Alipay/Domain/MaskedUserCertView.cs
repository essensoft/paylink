using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MaskedUserCertView Data Structure.
    /// </summary>
    public class MaskedUserCertView : AlipayObject
    {
        /// <summary>
        /// 是否通过实名认证， 是 - T； 否 - F
        /// </summary>
        [JsonPropertyName("is_certified")]
        public string IsCertified { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 脱敏后的姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
