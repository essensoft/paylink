using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMarketShopSummaryBatchqueryResponse.
    /// </summary>
    public class AlipayOfflineMarketShopSummaryBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("current_page_no")]
        public string CurrentPageNo { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        [JsonPropertyName("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 支付宝门店摘要信息列表
        /// </summary>
        [JsonPropertyName("shop_summary_infos")]
        public List<ShopSummaryQueryResponse> ShopSummaryInfos { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total_items")]
        public string TotalItems { get; set; }

        /// <summary>
        /// 总页码数目
        /// </summary>
        [JsonPropertyName("total_page_no")]
        public string TotalPageNo { get; set; }
    }
}
