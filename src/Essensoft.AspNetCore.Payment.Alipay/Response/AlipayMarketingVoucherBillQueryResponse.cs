using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingVoucherBillQueryResponse.
    /// </summary>
    public class AlipayMarketingVoucherBillQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前的页码数
        /// </summary>
        [JsonPropertyName("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页分页条数
        /// </summary>
        [JsonPropertyName("items_per_page")]
        public long ItemsPerPage { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonPropertyName("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 查询结果的总页数
        /// </summary>
        [JsonPropertyName("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 券账单信息
        /// </summary>
        [JsonPropertyName("voucher_bills")]
        public List<VoucherBill> VoucherBills { get; set; }
    }
}
