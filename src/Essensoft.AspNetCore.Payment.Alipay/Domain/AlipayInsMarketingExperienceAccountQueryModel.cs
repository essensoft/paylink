using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsMarketingExperienceAccountQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsMarketingExperienceAccountQueryModel : AlipayObject
    {
        /// <summary>
        /// 场景码
        /// </summary>
        [JsonProperty("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 用户2088
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
