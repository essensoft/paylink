using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// MybankMarketingCampaignPrizeListConsultResponse.
    /// </summary>
    public class MybankMarketingCampaignPrizeListConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 可用的奖品列表
        /// </summary>
        [JsonPropertyName("prize_list")]
        public List<PrizeModel> PrizeList { get; set; }
    }
}
