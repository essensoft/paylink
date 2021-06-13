using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceEnterpriseconsumeDetailQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceEnterpriseconsumeDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 账单信息
        /// </summary>
        [JsonPropertyName("expense_consume_info")]
        public ExpenseConsumeInfo ExpenseConsumeInfo { get; set; }

        /// <summary>
        /// 发票凭证结构化数据
        /// </summary>
        [JsonPropertyName("expense_invoice_info")]
        public ExpenseInvoiceInfo ExpenseInvoiceInfo { get; set; }

        /// <summary>
        /// 凭证基础信息
        /// </summary>
        [JsonPropertyName("voucher_info")]
        public ExpenseVoucherInfo VoucherInfo { get; set; }
    }
}
