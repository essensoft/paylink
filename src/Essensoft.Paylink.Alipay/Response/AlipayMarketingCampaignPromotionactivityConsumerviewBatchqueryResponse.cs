using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionactivityConsumerviewBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPromotionactivityConsumerviewBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 可领券的活动列表
        /// </summary>
        [JsonPropertyName("activities")]
        public List<MarketActivityInfo> Activities { get; set; }
    }
}
