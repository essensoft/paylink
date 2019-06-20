using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundCouponWufuCardQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundCouponWufuCardQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务场景码
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
