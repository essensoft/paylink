using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserDInfo Data Structure.
    /// </summary>
    public class UserDInfo : AlipayObject
    {
        /// <summary>
        /// 用户登陆号（手机号）
        /// </summary>
        [JsonPropertyName("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 用户蚂蚁身份id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
