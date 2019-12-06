using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPrizeAmountQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignPrizeAmountQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [JsonPropertyName("prize_id")]
        public string PrizeId { get; set; }
    }
}
