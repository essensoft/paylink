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

        /// <summary>
        /// 当前页数
        /// </summary>
        [JsonPropertyName("current_pages")]
        public string CurrentPages { get; set; }

        /// <summary>
        /// 每页活动数
        /// </summary>
        [JsonPropertyName("items_per_page")]
        public string ItemsPerPage { get; set; }

        /// <summary>
        /// 返回总活动数
        /// </summary>
        [JsonPropertyName("total_items")]
        public string TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_pages")]
        public string TotalPages { get; set; }
    }
}
