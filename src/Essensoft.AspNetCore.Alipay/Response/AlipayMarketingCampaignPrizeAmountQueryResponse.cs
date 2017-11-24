using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPrizeAmountQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPrizeAmountQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 奖品剩余数量，数值
        /// </summary>
        [JsonProperty("remain_amount")]
        public string RemainAmount { get; set; }
    }
}
