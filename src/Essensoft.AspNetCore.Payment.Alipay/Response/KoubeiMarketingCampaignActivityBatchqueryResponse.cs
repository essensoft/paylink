using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignActivityBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [JsonProperty("camp_sets")]
        public List<CampBaseDto> CampSets { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [JsonProperty("total_number")]
        public string TotalNumber { get; set; }
    }
}
