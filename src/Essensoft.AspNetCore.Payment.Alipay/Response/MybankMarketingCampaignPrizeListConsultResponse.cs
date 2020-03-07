using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
