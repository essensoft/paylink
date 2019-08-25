using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignBenefitQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignBenefitQueryModel : AlipayObject
    {
        /// <summary>
        /// 权益id
        /// </summary>
        [JsonProperty("benefit_id")]
        public string BenefitId { get; set; }
    }
}
