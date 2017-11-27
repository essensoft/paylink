using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignIntelligentShopConsultResponse.
    /// </summary>
    public class KoubeiMarketingCampaignIntelligentShopConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 总共项数
        /// </summary>
        [JsonProperty("items")]
        public string Items { get; set; }

        /// <summary>
        /// 智能营销方案符合标准的门店列表
        /// </summary>
        [JsonProperty("shops")]
        public List<IntelligentPromoShopSummaryInfo> Shops { get; set; }
    }
}
