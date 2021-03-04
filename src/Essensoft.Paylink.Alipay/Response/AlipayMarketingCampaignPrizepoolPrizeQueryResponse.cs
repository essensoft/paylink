using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPrizepoolPrizeQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPrizepoolPrizeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 指定奖品id的详细配置
        /// </summary>
        [JsonPropertyName("prize_config")]
        public PrizeConfig PrizeConfig { get; set; }
    }
}
