using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPrizepoolPrizeCreateResponse.
    /// </summary>
    public class AlipayMarketingCampaignPrizepoolPrizeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 奖品id
        /// </summary>
        [JsonPropertyName("prize_id")]
        public string PrizeId { get; set; }
    }
}
