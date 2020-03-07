using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncApbillCustviewBatchqueryResponse.
    /// </summary>
    public class AlipayBossFncApbillCustviewBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonPropertyName("items_page")]
        public long ItemsPage { get; set; }

        /// <summary>
        /// 应付月账单客户视图
        /// </summary>
        [JsonPropertyName("result_set")]
        public List<ApMonthlyBillCustOpenApiResponse> ResultSet { get; set; }

        /// <summary>
        /// 查询到的结果总数
        /// </summary>
        [JsonPropertyName("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_pages")]
        public long TotalPages { get; set; }
    }
}
