using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApInvoiceLineOrderRequest Data Structure.
    /// </summary>
    public class ApInvoiceLineOrderRequest : AlipayObject
    {
        /// <summary>
        /// 含税金额
        /// </summary>
        [JsonPropertyName("amt")]
        public MultiCurrencyMoneyOpenApi Amt { get; set; }

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
        /// (invoiceType=01 || invoiceType=02 必填）税额
        /// </summary>
        [JsonPropertyName("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }

        /// <summary>
        /// (invoiceType=01 || invoiceType=02 必填）不含税金额
        /// </summary>
        [JsonPropertyName("tax_exclusive_amt")]
        public MultiCurrencyMoneyOpenApi TaxExclusiveAmt { get; set; }

        /// <summary>
        /// (invoiceType=01 || invoiceType=02 必填，且大于0)税率
        /// </summary>
        [JsonPropertyName("tax_rate")]
        public long TaxRate { get; set; }

        /// <summary>
        /// 单价(元)
        /// </summary>
        [JsonPropertyName("unit_amt")]
        public long UnitAmt { get; set; }
    }
}
