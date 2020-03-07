using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayBossFncArbillMonthstatementbillQueryResponse.
    /// </summary>
    public class AlipayBossFncArbillMonthstatementbillQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("current_page")]
        public string CurrentPage { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        [JsonPropertyName("items_page")]
        public string ItemsPage { get; set; }

        /// <summary>
        /// 对账单开放平台返回结果
        /// </summary>
        [JsonPropertyName("result_set")]
        public List<ArMonthlyStatementBillOpenApiResponse> ResultSet { get; set; }

        /// <summary>
        /// 汇总服务费总调整金额
        /// </summary>
        [JsonPropertyName("total_adj_amt")]
        public MultiCurrencyMoneyOpenApi TotalAdjAmt { get; set; }

        /// <summary>
        /// 汇总服务费总金额
        /// </summary>
        [JsonPropertyName("total_bill_amt")]
        public MultiCurrencyMoneyOpenApi TotalBillAmt { get; set; }

        /// <summary>
        /// 汇总可开票总金额
        /// </summary>
        [JsonPropertyName("total_inv_amt")]
        public MultiCurrencyMoneyOpenApi TotalInvAmt { get; set; }

        /// <summary>
        /// 汇总已开票总金额
        /// </summary>
        [JsonPropertyName("total_inved_amt")]
        public MultiCurrencyMoneyOpenApi TotalInvedAmt { get; set; }

        /// <summary>
        /// 查询到的结果总数
        /// </summary>
        [JsonPropertyName("total_items")]
        public long TotalItems { get; set; }

        /// <summary>
        /// 汇总已关联票总金额
        /// </summary>
        [JsonPropertyName("total_link_invoice_amt")]
        public MultiCurrencyMoneyOpenApi TotalLinkInvoiceAmt { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        [JsonPropertyName("total_pages")]
        public long TotalPages { get; set; }

        /// <summary>
        /// 对账单开放平台查询返回结果
        /// </summary>
        [JsonPropertyName("total_received_amt")]
        public MultiCurrencyMoneyOpenApi TotalReceivedAmt { get; set; }
    }
}
