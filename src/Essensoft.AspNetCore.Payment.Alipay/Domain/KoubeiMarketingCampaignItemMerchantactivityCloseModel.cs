using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityCloseModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignItemMerchantactivityCloseModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("activity_id")]
        public string ActivityId { get; set; }
    }
}
