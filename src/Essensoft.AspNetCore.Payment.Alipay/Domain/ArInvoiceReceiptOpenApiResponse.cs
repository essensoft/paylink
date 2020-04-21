using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArInvoiceReceiptOpenApiResponse Data Structure.
    /// </summary>
    public class ArInvoiceReceiptOpenApiResponse : AlipayObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 可开票单据主键ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 机构ID
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 开票时间 格式：yyyymm
        /// </summary>
        [JsonPropertyName("inv_dt")]
        public string InvDt { get; set; }

        /// <summary>
        /// 开票模式  01：实收开票， 02：应收开票， 03：累计实收开票
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
        /// 结算ip_id
        /// </summary>
        [JsonPropertyName("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 结算对象ip_role_id
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        [JsonPropertyName("last_moder")]
        public string LastModer { get; set; }

        /// <summary>
        /// 已关联发票金额
        /// </summary>
        [JsonPropertyName("link_invoice_amt")]
        public MultiCurrencyMoneyOpenApi LinkInvoiceAmt { get; set; }

        /// <summary>
        /// 外部单据号，对应开票记录的月账单号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 可开票单据来源，01：主站，02：芝麻，03：金融云，04：微贷
        /// </summary>
        [JsonPropertyName("out_biz_type")]
        public string OutBizType { get; set; }

        /// <summary>
        /// 付款方式，1：资金，5：走量
        /// </summary>
        [JsonPropertyName("pay_way")]
        public string PayWay { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 结算类型 ，01：实时，02：预收，03：后收，04：周期性，05：按日汇总，09：延期结算
        /// </summary>
        [JsonPropertyName("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 开票金额消耗状态：01未开票，02部分开票，03：已开票
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonPropertyName("tax_rate")]
        public long TaxRate { get; set; }

        /// <summary>
        /// 税收类型01：增值税，02：营业税
        /// </summary>
        [JsonPropertyName("tax_type")]
        public string TaxType { get; set; }

        /// <summary>
        /// 租户ID
        /// </summary>
        [JsonPropertyName("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 类型，1：应收，2：返点
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
