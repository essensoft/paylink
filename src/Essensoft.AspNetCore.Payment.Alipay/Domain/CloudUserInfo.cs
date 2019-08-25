using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CloudUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CloudUserInfo : AlipayObject
    {
        /// <summary>
        /// 口碑主账号ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 口碑主账号名称
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
