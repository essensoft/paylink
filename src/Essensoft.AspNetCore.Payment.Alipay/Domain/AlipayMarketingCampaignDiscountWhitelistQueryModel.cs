using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignDiscountWhitelistQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignDiscountWhitelistQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动od
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }
    }
}
