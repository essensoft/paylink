using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncInvoiceBatchqueryResponse.
    /// </summary>
    public class AlipayBossFncInvoiceBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 发票总金额
        /// </summary>
        [JsonPropertyName("amt")]
        public MultiCurrencyMoneyOpenApi Amt { get; set; }

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
        /// 结果对象,发票对象的集合
        /// </summary>
        [JsonPropertyName("result_set")]
        public List<ArInvoiceOpenApiResponse> ResultSet { get; set; }

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
