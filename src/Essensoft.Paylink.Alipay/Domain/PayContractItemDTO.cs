using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PayContractItemDTO Data Structure.
    /// </summary>
    public class PayContractItemDTO : AlipayObject
    {
        /// <summary>
        /// 付款条款描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 计划行号会用于发起付款时进行作为幂等字段
        /// </summary>
        [JsonPropertyName("item_no")]
        public string ItemNo { get; set; }

        /// <summary>
        /// 后付款:POSTPAY_MONEY, 先付款 :PREPAY_MONEY, 质量保证金 :GUARANTEE_MONEY, 预付款 :ADVANCE_MONEY;
        /// </summary>
        [JsonPropertyName("item_type")]
        public string ItemType { get; set; }

        /// <summary>
        /// 是否有票
        /// </summary>
        [JsonPropertyName("need_invoice")]
        public bool NeedInvoice { get; set; }

        /// <summary>
        /// 付款申请时间
        /// </summary>
        [JsonPropertyName("pay_apply_date")]
        public string PayApplyDate { get; set; }

        /// <summary>
        /// 付款日期类型， 票到日 ：INVOICE_ARV_DATE 供方开票日 ：INVOICE_BILL_DATE 货到日 ：RCV_DATE 无票 ：NONE
        /// </summary>
        [JsonPropertyName("pay_ref_type")]
        public string PayRefType { get; set; }

        /// <summary>
        /// 付款期限
        /// </summary>
        [JsonPropertyName("pay_term")]
        public long PayTerm { get; set; }

        /// <summary>
        /// 付款期限类型 工作日-WORKING_DAY 自然日-CALENDAR_DAY
        /// </summary>
        [JsonPropertyName("pay_term_type")]
        public string PayTermType { get; set; }

        /// <summary>
        /// 付款金额-元
        /// </summary>
        [JsonPropertyName("payment_amount")]
        public string PaymentAmount { get; set; }

        /// <summary>
        /// 付款阶段
        /// </summary>
        [JsonPropertyName("phase")]
        public string Phase { get; set; }

        /// <summary>
        /// 条款描述内容
        /// </summary>
        [JsonPropertyName("terms")]
        public string Terms { get; set; }
    }
}
