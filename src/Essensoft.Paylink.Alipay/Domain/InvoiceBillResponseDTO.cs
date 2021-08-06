using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// InvoiceBillResponseDTO Data Structure.
    /// </summary>
    public class InvoiceBillResponseDTO : AlipayObject
    {
        /// <summary>
        /// 申请单聚合键
        /// </summary>
        [JsonPropertyName("apply_relative_id")]
        public string ApplyRelativeId { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 账单号
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 单据类型
        /// </summary>
        [JsonPropertyName("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 商户名称
        /// </summary>
        [JsonPropertyName("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 机构
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 机构名称
        /// </summary>
        [JsonPropertyName("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 关联发票受理单应票金额
        /// </summary>
        [JsonPropertyName("invaccept_receivable_amt")]
        public MultiCurrencyMoneyOpenApi InvacceptReceivableAmt { get; set; }

        /// <summary>
        /// 关联发票受理单已票金额
        /// </summary>
        [JsonPropertyName("invaccept_relevant_amt")]
        public MultiCurrencyMoneyOpenApi InvacceptRelevantAmt { get; set; }

        /// <summary>
        /// 可票金额 (固定不变的，不会根据已票金额变化而变化)*
        /// </summary>
        [JsonPropertyName("invoice_receivable_amount")]
        public MultiCurrencyMoneyOpenApi InvoiceReceivableAmount { get; set; }

        /// <summary>
        /// 已票金额（发票中心-发票认证时才会更新）
        /// </summary>
        [JsonPropertyName("invoice_received_amount")]
        public MultiCurrencyMoneyOpenApi InvoiceReceivedAmount { get; set; }

        /// <summary>
        /// 已发起付款金额
        /// </summary>
        [JsonPropertyName("issued_paid_amount")]
        public MultiCurrencyMoneyOpenApi IssuedPaidAmount { get; set; }

        /// <summary>
        /// 开票号
        /// </summary>
        [JsonPropertyName("kp_no")]
        public string KpNo { get; set; }

        /// <summary>
        /// 已付款金额
        /// </summary>
        [JsonPropertyName("paid_amount")]
        public MultiCurrencyMoneyOpenApi PaidAmount { get; set; }

        /// <summary>
        /// 可付款金额
        /// </summary>
        [JsonPropertyName("payable_amount")]
        public MultiCurrencyMoneyOpenApi PayableAmount { get; set; }

        /// <summary>
        /// 结算状态
        /// </summary>
        [JsonPropertyName("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 关联发票税额
        /// </summary>
        [JsonPropertyName("tax_amount")]
        public MultiCurrencyMoneyOpenApi TaxAmount { get; set; }

        /// <summary>
        /// 待付款金额=可付金额-已发起付款金额
        /// </summary>
        [JsonPropertyName("to_pay_amount")]
        public MultiCurrencyMoneyOpenApi ToPayAmount { get; set; }

        /// <summary>
        /// 未票金额=应票金额-已票金额
        /// </summary>
        [JsonPropertyName("un_invoice_received_amount")]
        public MultiCurrencyMoneyOpenApi UnInvoiceReceivedAmount { get; set; }

        /// <summary>
        /// 已核销金额
        /// </summary>
        [JsonPropertyName("wroteoff_amount")]
        public MultiCurrencyMoneyOpenApi WroteoffAmount { get; set; }
    }
}
