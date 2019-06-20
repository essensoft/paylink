using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingMallTradeBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingMallTradeBindModel : AlipayObject
    {
        /// <summary>
        /// 用户的授权动作：auth授权，unAuth取消授权
        /// </summary>
        [JsonProperty("action")]
        public string Action { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
