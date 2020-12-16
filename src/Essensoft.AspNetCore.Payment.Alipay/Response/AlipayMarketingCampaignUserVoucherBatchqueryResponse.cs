using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignUserVoucherBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingCampaignUserVoucherBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当面页数
        /// </summary>
        [JsonPropertyName("current_pages")]
        public string CurrentPages { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonPropertyName("items_per_page")]
        public string ItemsPerPage { get; set; }

        /// <summary>
        /// 返回总条目数
        /// </summary>
        [JsonPropertyName("total_items")]
        public string TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_pages")]
        public string TotalPages { get; set; }

        /// <summary>
        /// 券详情列表
        /// </summary>
        [JsonPropertyName("voucher_item_list")]
        public List<VoucherItem> VoucherItemList { get; set; }
    }
}
