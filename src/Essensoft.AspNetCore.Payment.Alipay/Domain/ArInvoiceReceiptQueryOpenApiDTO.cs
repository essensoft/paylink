using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArInvoiceReceiptQueryOpenApiDTO Data Structure.
    /// </summary>
    public class ArInvoiceReceiptQueryOpenApiDTO : AlipayObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 开票单据id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 我方ou
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 开票时间
        /// </summary>
        [JsonPropertyName("inv_dt")]
        public string InvDt { get; set; }

        /// <summary>
        /// 开票模式 01 实收开票 02 应收开票 03 累计实收开票
        /// </summary>
        [JsonPropertyName("inv_mode")]
        public string InvMode { get; set; }

        /// <summary>
        /// 可开票金额
        /// </summary>
        [JsonPropertyName("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 已开票金额
        /// </summary>
        [JsonPropertyName("invoiced_amt")]
        public MultiCurrencyMoneyOpenApi InvoicedAmt { get; set; }

        /// <summary>
        /// 商户号（可能为空）
        /// </summary>
        [JsonPropertyName("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 已关联发票金额
        /// </summary>
        [JsonPropertyName("link_invoice_amt")]
        public MultiCurrencyMoneyOpenApi LinkInvoiceAmt { get; set; }

        /// <summary>
        /// 外部单据号（对应月账单号或者结算单号）
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 结算类型  01实时，02预收 03后收 04周期性 05按日汇总 06周期性 09 延期结算
        /// </summary>
        [JsonPropertyName("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 对账单号
        /// </summary>
        [JsonPropertyName("statement_bill_no")]
        public string StatementBillNo { get; set; }

        /// <summary>
        /// 开票状态 01 未开票 02 部分开票 03 完全开票
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonPropertyName("tax_rate")]
        public long TaxRate { get; set; }

        /// <summary>
        /// 税种 01 增值税 02 营业税
        /// </summary>
        [JsonPropertyName("tax_type")]
        public string TaxType { get; set; }
    }
}
