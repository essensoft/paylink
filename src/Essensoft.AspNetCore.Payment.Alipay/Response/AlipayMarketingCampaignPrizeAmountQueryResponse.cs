using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPrizeAmountQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPrizeAmountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 奖品剩余数量，数值
        /// </summary>
        [JsonPropertyName("remain_amount")]
        public string RemainAmount { get; set; }
    }
}
