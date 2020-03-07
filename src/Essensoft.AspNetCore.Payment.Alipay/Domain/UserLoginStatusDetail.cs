using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserLoginStatusDetail Data Structure.
    /// </summary>
    public class UserLoginStatusDetail : AlipayObject
    {
        /// <summary>
        /// 口碑云子账号联系人邮箱
        /// </summary>
        [JsonPropertyName("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 口碑云子账号联系人名称
        /// </summary>
        [JsonPropertyName("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 口碑云子账号联系人联系方式
        /// </summary>
        [JsonPropertyName("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 口碑云子账号id
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 口碑云子账号名称
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 口碑云子账户显示名
        /// </summary>
        [JsonPropertyName("user_show_name")]
        public string UserShowName { get; set; }
    }
}
