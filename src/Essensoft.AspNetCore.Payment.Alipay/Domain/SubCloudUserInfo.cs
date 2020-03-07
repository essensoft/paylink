using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SubCloudUserInfo Data Structure.
    /// </summary>
    public class SubCloudUserInfo : AlipayObject
    {
        /// <summary>
        /// 口碑子账号ID
        /// </summary>
        [JsonPropertyName("sub_user_id")]
        public string SubUserId { get; set; }

        /// <summary>
        /// 口碑子账号名称
        /// </summary>
        [JsonPropertyName("sub_user_name")]
        public string SubUserName { get; set; }

        /// <summary>
        /// 口碑子账号显示名
        /// </summary>
        [JsonPropertyName("sub_user_show_name")]
        public string SubUserShowName { get; set; }

        /// <summary>
        /// 口碑主账号ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 口碑主账号名称
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
