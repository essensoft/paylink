using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignSelfActivityBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignSelfActivityBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [JsonPropertyName("activity_list")]
        public List<MarketingActivityInfo> ActivityList { get; set; }
    }
}
