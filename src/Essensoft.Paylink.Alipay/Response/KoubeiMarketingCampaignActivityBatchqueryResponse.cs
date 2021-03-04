using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingCampaignActivityBatchqueryResponse.
    /// </summary>
    public class KoubeiMarketingCampaignActivityBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [JsonPropertyName("camp_sets")]
        public List<CampBaseDto> CampSets { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        [JsonPropertyName("total_number")]
        public string TotalNumber { get; set; }
    }
}
