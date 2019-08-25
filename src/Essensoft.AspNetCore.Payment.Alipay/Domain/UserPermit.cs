using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserPermit Data Structure.
    /// </summary>
    [Serializable]
    public class UserPermit : AlipayObject
    {
        /// <summary>
        /// 用户授权接收消息状态
        /// </summary>
        [JsonProperty("permit_status")]
        public string PermitStatus { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
