using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
