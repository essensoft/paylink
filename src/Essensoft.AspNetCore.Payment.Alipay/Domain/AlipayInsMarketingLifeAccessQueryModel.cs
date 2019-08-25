using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsMarketingLifeAccessQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingLifeAccessQueryModel : AlipayObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [JsonProperty("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
