using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MaskedLogonIdView Data Structure.
    /// </summary>
    public class MaskedLogonIdView : AlipayObject
    {
        /// <summary>
        /// 脱敏后的支付宝邮箱登录名，如果用户没有邮箱登录名，则返回空。
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 脱敏后的手机号登录名，如果用户没有手机号登录名，则返回空。大陆手机为11位数字，非大陆由地区码、横杠和号码拼接而成。
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
