using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GeneralInvoiceItem Data Structure.
    /// </summary>
    public class GeneralInvoiceItem : AlipayObject
    {
        /// <summary>
        /// 价税合计。(等于sumPrice和tax之和)， 单位：元，格式为2位小数，精度2位小数
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 发票项目名称（或商品名称）
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 发票项目编号（或商品编号）
        /// </summary>
        [JsonPropertyName("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 单价（不含税），2到6位小数。格式为2位小数。 折扣行此参数不能传，非折扣行必传
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 数量，最多6位小数。 折扣行此参数不能传，非折扣行必传。存在则需>0
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 发票行性质。0表示正常行，1表示折扣行，2表示被折扣行。 比如充电器单价100元，折扣10元，则明细为2行，充电器行性质为2，折扣行性质为1。如果充电器没有折扣，则值应为0。
        /// </summary>
        [JsonPropertyName("row_type")]
        public string RowType { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        [JsonPropertyName("specification")]
        public string Specification { get; set; }

        /// <summary>
        /// 总价 (不含税)，格式为2位小数 单位：元，精度2位小数
        /// </summary>
        [JsonPropertyName("sum_price")]
        public string SumPrice { get; set; }

        /// <summary>
        /// 税额，格式为2位小数
        /// </summary>
        [JsonPropertyName("tax")]
        public string Tax { get; set; }

        /// <summary>
        /// 单价（含税），格式为2位小数。最大支持6位小数，不足2位小数时需转化为2位小数格式。 折扣行此参数不能传，非折扣行必传。当auto_preprocess=true 只能传一个，不能同时传。当auto_preprocess=false, tax_price字段无用，勿传。此时开票需要传price
        /// </summary>
        [JsonPropertyName("tax_price")]
        public string TaxPrice { get; set; }

        /// <summary>
        /// 税率。税率只能为0.00或0.03或0.04或0.06或0.11或0.13或0.17
        /// </summary>
        [JsonPropertyName("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 单位。折扣行不能传，非折扣行必传
        /// </summary>
        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        /// <summary>
        /// 0税率标识，只有税率为0的情况才有值，0=出口零税率，1=免税，2=不征收，3=普通零税率
        /// </summary>
        [JsonPropertyName("zero_rate_flag")]
        public string ZeroRateFlag { get; set; }
    }
}
