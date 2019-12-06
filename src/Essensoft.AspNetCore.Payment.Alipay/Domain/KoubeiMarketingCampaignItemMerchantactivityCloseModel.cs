using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignItemMerchantactivityCloseModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignItemMerchantactivityCloseModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }
    }
}
