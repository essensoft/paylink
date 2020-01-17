using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceItemApplyOpenModel Data Structure.
    /// </summary>
    public class InvoiceItemApplyOpenModel : AlipayObject
    {
        /// <summary>
        /// 明细不含税金额，该值为item_quantity＊item_unit_price，依据税控厂商的不同，目前对接的阿里平台和浙江航信该字段不必传
        /// </summary>
        [JsonPropertyName("item_ex_tax_amount")]
        public string ItemExTaxAmount { get; set; }

        /// <summary>
        /// 发票项目名称（或商品名称）
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 商品编号
        /// </summary>
        [JsonPropertyName("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 数量。新版电子发票，折扣行此参数不能传，非折扣行必传
        /// </summary>
        [JsonPropertyName("item_quantity")]
        public long ItemQuantity { get; set; }

        /// <summary>
        /// 商品型号
        /// </summary>
        [JsonPropertyName("item_spec")]
        public string ItemSpec { get; set; }

        /// <summary>
        /// 明细价税合计。该值为item_tax_amount＋item_ex_tax_amount，依据税控厂商的不同，目前对接的阿里平台和浙江航信该字段可不传
        /// </summary>
        [JsonPropertyName("item_sum_amount")]
        public string ItemSumAmount { get; set; }

        /// <summary>
        /// 明细税额，该值为item_ex_tax_amount*item_tax_rate,依据税控厂商的不同，对于目前对接的浙江航信和阿里平台，该字段可不传
        /// </summary>
        [JsonPropertyName("item_tax_amount")]
        public string ItemTaxAmount { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonPropertyName("item_tax_rate")]
        public string ItemTaxRate { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonPropertyName("item_unit")]
        public string ItemUnit { get; set; }

        /// <summary>
        /// 单价，格式：100.00。新版电子发票，折扣行此参数不能传，非折扣行必传
        /// </summary>
        [JsonPropertyName("item_unit_price")]
        public string ItemUnitPrice { get; set; }

        /// <summary>
        /// 优惠政策标识。0：没有优惠政策；1：对应零税率为免税或者不征税
        /// </summary>
        [JsonPropertyName("prefer_policy_flag")]
        public string PreferPolicyFlag { get; set; }

        /// <summary>
        /// 发票行性质。0表示正常行，1表示折扣行，2表示被折扣行。比如充电器单价100元，折扣10元，则明细为2行，充电器行性质为2，折扣行性质为1。如果充电器没有折扣，则值应为0
        /// </summary>
        [JsonPropertyName("row_type")]
        public string RowType { get; set; }

        /// <summary>
        /// 增值税特殊管理。该标识会展示在票面上，和优惠政策标识和零税率标识强关联；如果是免税，在税率那一行展示“免税”；如果是不征税，在税率那一行展示“不征税”
        /// </summary>
        [JsonPropertyName("special_manage_flag")]
        public string SpecialManageFlag { get; set; }

        /// <summary>
        /// 零税率标识。为空：非零税率； 1：免税；2：不征税；3：普通零税率
        /// </summary>
        [JsonPropertyName("zero_tax_flag")]
        public string ZeroTaxFlag { get; set; }
    }
}
