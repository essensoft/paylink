using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountWhitelistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingCampaignDiscountWhitelistQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动od
        /// </summary>
        [JsonProperty("camp_id")]
        public string CampId { get; set; }
    }
}
