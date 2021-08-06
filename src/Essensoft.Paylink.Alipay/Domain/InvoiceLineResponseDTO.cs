using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InvoiceLineResponseDTO Data Structure.
    /// </summary>
    public class InvoiceLineResponseDTO : AlipayObject
    {
        /// <summary>
        /// 含税金额
        /// </summary>
        [JsonPropertyName("amt")]
        public MultiCurrencyMoneyOpenApi Amt { get; set; }

        /// <summary>
        /// 发票id
        /// </summary>
        [JsonPropertyName("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票行id
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
        public string Quantity { get; set; }

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
        public string TaxRate { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [JsonPropertyName("unit_amt")]
        public string UnitAmt { get; set; }
    }
}
