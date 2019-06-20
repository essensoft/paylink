using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArInvoiceLineOpenApiResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ArInvoiceLineOpenApiResponse : AlipayObject
    {
        /// <summary>
        /// 含税金额
        /// </summary>
        [JsonProperty("amt")]
        public MultiCurrencyMoneyOpenApi Amt { get; set; }

        /// <summary>
        /// 关联的发票ID
        /// </summary>
        [JsonProperty("invoice_id")]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票行iD
        /// </summary>
        [JsonProperty("invoice_line_id")]
        public string InvoiceLineId { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        [JsonProperty("measurement_unit")]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// 货物或劳务名称
        /// </summary>
        [JsonProperty("product_name")]
        public string ProductName { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [JsonProperty("product_specification")]
        public string ProductSpecification { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [JsonProperty("quantity")]
        public long Quantity { get; set; }

        /// <summary>
        /// 税额
        /// </summary>
        [JsonProperty("tax_amt")]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }

        /// <summary>
        /// 不含税金额
        /// </summary>
        [JsonProperty("tax_exclusive_amt")]
        public MultiCurrencyMoneyOpenApi TaxExclusiveAmt { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonProperty("tax_rate")]
        public long TaxRate { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [JsonProperty("unit_amt")]
        public long UnitAmt { get; set; }
    }
}
