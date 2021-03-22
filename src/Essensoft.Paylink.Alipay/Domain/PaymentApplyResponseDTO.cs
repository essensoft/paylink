using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PaymentApplyResponseDTO Data Structure.
    /// </summary>
    public class PaymentApplyResponseDTO : AlipayObject
    {
        /// <summary>
        /// 申请单号
        /// </summary>
        [JsonPropertyName("apply_relative_id")]
        public string ApplyRelativeId { get; set; }

        /// <summary>
        /// 合约号
        /// </summary>
        [JsonPropertyName("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 单据类型
        /// </summary>
        [JsonPropertyName("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 供应商名称
        /// </summary>
        [JsonPropertyName("customer_name")]
        public string CustomerName { get; set; }

        /// <summary>
        /// 是否是质量保证金额
        /// </summary>
        [JsonPropertyName("guarantee_noney")]
        public string GuaranteeNoney { get; set; }

        /// <summary>
        /// OU代码
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// OU名称
        /// </summary>
        [JsonPropertyName("inst_name")]
        public string InstName { get; set; }

        /// <summary>
        /// 应票金额
        /// </summary>
        [JsonPropertyName("invaccept_receivable_amt")]
        public MultiCurrencyMoneyOpenApi InvacceptReceivableAmt { get; set; }

        /// <summary>
        /// 关联发票受理单，已票金额
        /// </summary>
        [JsonPropertyName("invaccept_relevant_amt")]
        public MultiCurrencyMoneyOpenApi InvacceptRelevantAmt { get; set; }

        /// <summary>
        /// 可票金额 (固定不变的，不会根据已票金额变化而变化)
        /// </summary>
        [JsonPropertyName("invoice_receivable_amount")]
        public MultiCurrencyMoneyOpenApi InvoiceReceivableAmount { get; set; }

        /// <summary>
        /// 已认证金额
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
        /// 付款描述
        /// </summary>
        [JsonPropertyName("pay_contract_desc")]
        public string PayContractDesc { get; set; }

        /// <summary>
        /// 付款条款行ID
        /// </summary>
        [JsonPropertyName("pay_contract_item_no")]
        public string PayContractItemNo { get; set; }

        /// <summary>
        /// 可付款金额
        /// </summary>
        [JsonPropertyName("payable_amount")]
        public MultiCurrencyMoneyOpenApi PayableAmount { get; set; }

        /// <summary>
        /// RT号
        /// </summary>
        [JsonPropertyName("rt_no")]
        public string RtNo { get; set; }

        /// <summary>
        /// 状态：已结算、未结算、部分结算
        /// </summary>
        [JsonPropertyName("settle_status")]
        public string SettleStatus { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 付款阶段
        /// </summary>
        [JsonPropertyName("stage")]
        public string Stage { get; set; }

        /// <summary>
        /// 开票资料-账号
        /// </summary>
        [JsonPropertyName("tax_account_no")]
        public string TaxAccountNo { get; set; }

        /// <summary>
        /// 开票资料-地址
        /// </summary>
        [JsonPropertyName("tax_address")]
        public string TaxAddress { get; set; }

        /// <summary>
        /// 发票税额
        /// </summary>
        [JsonPropertyName("tax_amount")]
        public MultiCurrencyMoneyOpenApi TaxAmount { get; set; }

        /// <summary>
        /// 开票资料-银行
        /// </summary>
        [JsonPropertyName("tax_bank_name")]
        public string TaxBankName { get; set; }

        /// <summary>
        /// 开票资料-名称
        /// </summary>
        [JsonPropertyName("tax_invoice_title")]
        public string TaxInvoiceTitle { get; set; }

        /// <summary>
        /// 开票资料-电话
        /// </summary>
        [JsonPropertyName("tax_phone_no")]
        public string TaxPhoneNo { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [JsonPropertyName("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 开票资料-税号
        /// </summary>
        [JsonPropertyName("tax_tax_no")]
        public string TaxTaxNo { get; set; }

        /// <summary>
        /// 开票资料-类型
        /// </summary>
        [JsonPropertyName("tax_type")]
        public string TaxType { get; set; }

        /// <summary>
        /// 开票资料-类型名称
        /// </summary>
        [JsonPropertyName("tax_type_desc")]
        public string TaxTypeDesc { get; set; }

        /// <summary>
        /// 待付款金额=可付金额-已发起付款金额
        /// </summary>
        [JsonPropertyName("to_pay_amount")]
        public MultiCurrencyMoneyOpenApi ToPayAmount { get; set; }

        /// <summary>
        /// 未确认金额=已票金额-已认证
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
