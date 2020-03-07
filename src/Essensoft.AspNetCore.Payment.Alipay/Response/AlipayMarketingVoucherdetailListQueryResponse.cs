using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingVoucherdetailListQueryResponse.
    /// </summary>
    public class AlipayMarketingVoucherdetailListQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前的页码数
        /// </summary>
        [JsonPropertyName("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每一页的分页条数
        /// </summary>
        [JsonPropertyName("items_per_page")]
        public long ItemsPerPage { get; set; }

        /// <summary>
        /// 当前总记录数
        /// </summary>
        [JsonPropertyName("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 券详情
        /// </summary>
        [JsonPropertyName("vouchers")]
        public List<VoucherQueryInfo> Vouchers { get; set; }
    }
}
