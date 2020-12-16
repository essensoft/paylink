using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingCampaignPrizepoolPrizeQueryModel Data Structure.
    /// </summary>
    public class AlipayMarketingCampaignPrizepoolPrizeQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动id,由蚂蚁营销产品统一分配
        /// </summary>
        [JsonPropertyName("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 奖品池id,由蚂蚁营销产品统一分配
        /// </summary>
        [JsonPropertyName("pool_id")]
        public string PoolId { get; set; }

        /// <summary>
        /// 奖品id
        /// </summary>
        [JsonPropertyName("prize_id")]
        public string PrizeId { get; set; }
    }
}
