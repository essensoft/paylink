using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArInvoiceLineOpenApiResponse Data Structure.
    /// </summary>
    public class ArInvoiceLineOpenApiResponse : AlipayObject
    {
        /// <summary>
        /// 含税金额
        /// </summary>
        [JsonPropertyName("amt")]
        public MultiCurrencyMoneyOpenApi Amt { get; set; }

        /// <summary>
        /// 关联的发票ID
        /// </summary>
        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票行iD
        /// </summary>
        [JsonPropertyName("invoice_line_id")]
        public string InvoiceLineId { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        [JsonPropertyName("measurement_unit")]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// 货物或劳务名称
        /// </summary>
        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [JsonPropertyName("product_specification")]
        public string ProductSpecification { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonPropertyName("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [JsonPropertyName("tax_exclusive_amt")]
        public MultiCurrencyMoneyOpenApi TaxExclusiveAmt { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonPropertyName("tax_rate")]
        public long TaxRate { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [JsonPropertyName("unit_amt")]
        public long UnitAmt { get; set; }
    }
}
