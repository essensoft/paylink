using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InvoiceResponseDTO Data Structure.
    /// </summary>
    public class InvoiceResponseDTO : AlipayObject
    {
        /// <summary>
        /// 不含税金额
        /// </summary>
        [JsonPropertyName("exclude_tax_invoice_amt")]
        public MultiCurrencyMoneyOpenApi ExcludeTaxInvoiceAmt { get; set; }

        /// <summary>
        /// 票面含税金额
        /// </summary>
        [JsonPropertyName("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [JsonPropertyName("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期 格式(yyyyMMdd)
        /// </summary>
        [JsonPropertyName("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票ID
        /// </summary>
        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonPropertyName("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 收票日期 格式(yyyyMMdd)
        /// </summary>
        [JsonPropertyName("invoice_rcv_date")]
        public string InvoiceRcvDate { get; set; }

        /// <summary>
        /// 01 发票已提交;02 审核中(已收票);03 已审核;04 已驳回;05 已认证;06 已撤回
        /// </summary>
        [JsonPropertyName("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// * 01,增值税专用发票; * 02,增值税普通发票; * 04,国际形式发票; * 05,其它发票
        /// </summary>
        [JsonPropertyName("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 发票种类名称
        /// </summary>
        [JsonPropertyName("invoice_type_name")]
        public string InvoiceTypeName { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonPropertyName("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonPropertyName("tax_rate")]
        public string TaxRate { get; set; }
    }
}
