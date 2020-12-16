using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncApinvoiceRcptQueryResponse.
    /// </summary>
    public class AlipayBossFncApinvoiceRcptQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页
        /// </summary>
        [JsonPropertyName("current_page")]
        public long CurrentPage { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonPropertyName("items_page")]
        public long ItemsPage { get; set; }

        /// <summary>
        /// 返回结果对象：可开票单据
        /// </summary>
        [JsonPropertyName("result_set")]
        public List<ArInvoiceReceiptOpenApiResponse> ResultSet { get; set; }

        /// <summary>
        /// 可开票总金额，可开票单据返回集合中可开票金额汇总
        /// </summary>
        [JsonPropertyName("total_inv_amt")]
        public MultiCurrencyMoneyOpenApi TotalInvAmt { get; set; }

        /// <summary>
        /// 已开票总金额，可开票单据返回集合中已开票金额汇总
        /// </summary>
        [JsonPropertyName("total_inved_amt")]
        public MultiCurrencyMoneyOpenApi TotalInvedAmt { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [JsonPropertyName("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 关联票总金额，可开票单据返回集合中关联金额汇总
        /// </summary>
        [JsonPropertyName("total_link_invoice_amt")]
        public MultiCurrencyMoneyOpenApi TotalLinkInvoiceAmt { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_pages")]
        public long TotalPages { get; set; }
    }
}
