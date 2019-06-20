using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserLoginStatusDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UserLoginStatusDetail : AlipayObject
    {
        /// <summary>
        /// 口碑云子账号联系人邮箱
        /// </summary>
        [JsonProperty("contact_email")]
        public string ContactEmail { get; set; }

        /// <summary>
        /// 口碑云子账号联系人名称
        /// </summary>
        [JsonProperty("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 口碑云子账号联系人联系方式
        /// </summary>
        [JsonProperty("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 口碑云子账号id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 口碑云子账号名称
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 口碑云子账户显示名
        /// </summary>
        [JsonProperty("user_show_name")]
        public string UserShowName { get; set; }
    }
}
