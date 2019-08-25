using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CardInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardInfo : AlipayObject
    {
        /// <summary>
        /// 领取时间
        /// </summary>
        [JsonProperty("taken_time")]
        public string TakenTime { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
