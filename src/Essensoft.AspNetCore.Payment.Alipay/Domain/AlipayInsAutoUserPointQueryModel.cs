using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoUserPointQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoUserPointQueryModel : AlipayObject
    {
        /// <summary>
        /// 车险活动类型编码。  攒油活动：SAVE_OIL
        /// </summary>
        [JsonProperty("auto_campaign_type")]
        public string AutoCampaignType { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
