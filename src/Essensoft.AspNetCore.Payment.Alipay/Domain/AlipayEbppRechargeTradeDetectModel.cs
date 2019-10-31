using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppRechargeTradeDetectModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppRechargeTradeDetectModel : AlipayObject
    {
        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonProperty("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
