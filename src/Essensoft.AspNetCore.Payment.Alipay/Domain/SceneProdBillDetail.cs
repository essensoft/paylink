using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneProdBillDetail Data Structure.
    /// </summary>
    public class SceneProdBillDetail : AlipayObject
    {
        /// <summary>
        /// 账单类型，包括：正常，手续费，保证金 等类型，根据机构需求可以进行扩展。非必填，不填默认为正常。
        /// </summary>
        [JsonPropertyName("bill_type")]
        public string BillType { get; set; }

        /// <summary>
        /// 结清日，时间格式为yyyy-MM-dd，如果为空，系统默认会以将账单改为已结清或者已处置状态的日期作为结清日
        /// </summary>
        [JsonPropertyName("clear_date")]
        public string ClearDate { get; set; }

        /// <summary>
        /// 货币类型， 不填写默认是人民币（156）
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 贴息金额，单位：分
        /// </summary>
        [JsonPropertyName("discount_amt")]
        public string DiscountAmt { get; set; }

        /// <summary>
        /// 到期日，时间格式为yyyy-MM-dd
        /// </summary>
        [JsonPropertyName("due_date")]
        public string DueDate { get; set; }

        /// <summary>
        /// 应还利息，单位分
        /// </summary>
        [JsonPropertyName("int_amt")]
        public string IntAmt { get; set; }

        /// <summary>
        /// 其它收费项，单位分
        /// </summary>
        [JsonPropertyName("other_amt")]
        public string OtherAmt { get; set; }

        /// <summary>
        /// 逾期天数，只能为数字，无逾期传0
        /// </summary>
        [JsonPropertyName("overdue_days")]
        public string OverdueDays { get; set; }

        /// <summary>
        /// 已还的利息金额，单位：分
        /// </summary>
        [JsonPropertyName("paid_int_amt")]
        public string PaidIntAmt { get; set; }

        /// <summary>
        /// 已还的其他收费项，单位：分
        /// </summary>
        [JsonPropertyName("paid_other_amt")]
        public string PaidOtherAmt { get; set; }

        /// <summary>
        /// 已还的罚息金额，单位：分
        /// </summary>
        [JsonPropertyName("paid_pen_amt")]
        public string PaidPenAmt { get; set; }

        /// <summary>
        /// 已还的本金金额，单位：分
        /// </summary>
        [JsonPropertyName("paid_prin_amt")]
        public string PaidPrinAmt { get; set; }

        /// <summary>
        /// 已还的总金额，单位：分
        /// </summary>
        [JsonPropertyName("paid_total_amt")]
        public string PaidTotalAmt { get; set; }

        /// <summary>
        /// 应还罚息，单位：分
        /// </summary>
        [JsonPropertyName("pen_amt")]
        public string PenAmt { get; set; }

        /// <summary>
        /// 应还本金，单位分
        /// </summary>
        [JsonPropertyName("prin_amt")]
        public string PrinAmt { get; set; }

        /// <summary>
        /// 实际还款日（仅修复数据时使用）
        /// </summary>
        [JsonPropertyName("real_repay_date")]
        public string RealRepayDate { get; set; }

        /// <summary>
        /// 账单备注信息
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 当期账单状态，可以选择的枚举值为：正常(NORMAL)，已结清(CLEAR)，逾期(OVERDUE), 已处置（DISPOSAL）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 期数，只能填写大于0的数字
        /// </summary>
        [JsonPropertyName("term")]
        public string Term { get; set; }

        /// <summary>
        /// 期次结束日
        /// </summary>
        [JsonPropertyName("term_end_date")]
        public string TermEndDate { get; set; }

        /// <summary>
        /// 期次开始日
        /// </summary>
        [JsonPropertyName("term_start_date")]
        public string TermStartDate { get; set; }

        /// <summary>
        /// 应还总金额，单位分
        /// </summary>
        [JsonPropertyName("total_amt")]
        public string TotalAmt { get; set; }
    }
}
