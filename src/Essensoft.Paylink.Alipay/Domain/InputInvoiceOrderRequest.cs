using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InputInvoiceOrderRequest Data Structure.
    /// </summary>
    public class InputInvoiceOrderRequest : AlipayObject
    {
        /// <summary>
        /// 购方机构OU
        /// </summary>
        [JsonPropertyName("buyer_inst_id")]
        public string BuyerInstId { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// 不含税金额-元
        /// </summary>
        [JsonPropertyName("exclude_tax_invoice_amt")]
        public string ExcludeTaxInvoiceAmt { get; set; }

        /// <summary>
        /// 票面金额-元
        /// </summary>
        [JsonPropertyName("invoice_amt")]
        public string InvoiceAmt { get; set; }

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
        /// 发票介质 01-电子 02-纸质
        /// </summary>
        [JsonPropertyName("invoice_material")]
        public string InvoiceMaterial { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [JsonPropertyName("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 收票日期 格式(yyyyMMdd)
        /// </summary>
        [JsonPropertyName("invoice_receive_date")]
        public string InvoiceReceiveDate { get; set; }

        /// <summary>
        /// 发票录入来源  04:集采录入
        /// </summary>
        [JsonPropertyName("invoice_source")]
        public string InvoiceSource { get; set; }

        /// <summary>
        /// 发票种类 01增值税专用发票 02增值税普通发票 03国际形式发票
        /// </summary>
        [JsonPropertyName("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 关联的单据号
        /// </summary>
        [JsonPropertyName("out_bill_no")]
        public string OutBillNo { get; set; }

        /// <summary>
        /// 业务单号类型
        /// </summary>
        [JsonPropertyName("out_bill_type")]
        public string OutBillType { get; set; }

        /// <summary>
        /// 账单关联发票金额-元
        /// </summary>
        [JsonPropertyName("relate_amount")]
        public string RelateAmount { get; set; }

        /// <summary>
        /// 关联到账单上的税额-元
        /// </summary>
        [JsonPropertyName("relate_tax_amt")]
        public string RelateTaxAmt { get; set; }

        /// <summary>
        /// 销方角色2088账号pid
        /// </summary>
        [JsonPropertyName("seller_ip_role_id")]
        public string SellerIpRoleId { get; set; }

        /// <summary>
        /// 系统来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 票面税额-元
        /// </summary>
        [JsonPropertyName("tax_amt")]
        public string TaxAmt { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonPropertyName("tax_rate")]
        public string TaxRate { get; set; }
    }
}
