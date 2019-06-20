using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhubUidTelPair Data Structure.
    /// </summary>
    [Serializable]
    public class ZhubUidTelPair : AlipayObject
    {
        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
