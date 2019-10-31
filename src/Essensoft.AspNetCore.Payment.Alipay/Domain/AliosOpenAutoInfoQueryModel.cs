using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AliosOpenAutoInfoQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AliosOpenAutoInfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 设备token
        /// </summary>
        [JsonProperty("device_token")]
        public string DeviceToken { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
