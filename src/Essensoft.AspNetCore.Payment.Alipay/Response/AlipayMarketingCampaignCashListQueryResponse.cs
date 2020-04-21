using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignCashListQueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignCashListQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [JsonPropertyName("camp_list")]
        public List<CashCampaignInfo> CampList { get; set; }

        /// <summary>
        /// 分页的页码,起始从1开始
        /// </summary>
        [JsonPropertyName("page_index")]
        public string PageIndex { get; set; }

        /// <summary>
        /// 分页每页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 活动总个数
        /// </summary>
        [JsonPropertyName("total_size")]
        public string TotalSize { get; set; }
    }
}
