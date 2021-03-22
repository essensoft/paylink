using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignPromotionactivityMerchantviewBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignPromotionactivityMerchantviewBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [JsonPropertyName("activities")]
        public List<MarketActivityInfo> Activities { get; set; }

        /// <summary>
        /// 分页器
        /// </summary>
        [JsonPropertyName("paginator")]
        public Paginator Paginator { get; set; }
    }
}
