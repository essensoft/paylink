using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InstallmentRepayPlan Data Structure.
    /// </summary>
    public class InstallmentRepayPlan : AlipayObject
    {
        /// <summary>
        /// 是否是当期 ?? 默认值为不是当期计划。如果合约最后一期计划都已经逾期，就不再存在当期计划，合约下所有计划明细的该值都为false
        /// </summary>
        [JsonPropertyName("cur_term")]
        public bool CurTerm { get; set; }

        /// <summary>
        /// 当期已还利息
        /// </summary>
        [JsonPropertyName("paid_int_bal")]
        public string PaidIntBal { get; set; }

        /// <summary>
        /// 当期已还本金
        /// </summary>
        [JsonPropertyName("paid_prin_bal")]
        public string PaidPrinBal { get; set; }

        /// <summary>
        /// 分期状态（NORMAL：正常，OVD：逾期，CLEAR：已结清)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 本期到期日
        /// </summary>
        [JsonPropertyName("term_end_date")]
        public string TermEndDate { get; set; }

        /// <summary>
        /// 期次号
        /// </summary>
        [JsonPropertyName("term_no")]
        public long TermNo { get; set; }

        /// <summary>
        /// 当期利息
        /// </summary>
        [JsonPropertyName("term_nom_int")]
        public string TermNomInt { get; set; }

        /// <summary>
        /// 当期本金
        /// </summary>
        [JsonPropertyName("term_nom_prin")]
        public string TermNomPrin { get; set; }

        /// <summary>
        /// 当期已还利息罚息
        /// </summary>
        [JsonPropertyName("term_ovd_int")]
        public string TermOvdInt { get; set; }

        /// <summary>
        /// 当期利息罚息
        /// </summary>
        [JsonPropertyName("term_ovd_int_pen_int")]
        public string TermOvdIntPenInt { get; set; }

        /// <summary>
        /// 当期已还本金罚息
        /// </summary>
        [JsonPropertyName("term_ovd_prin")]
        public string TermOvdPrin { get; set; }

        /// <summary>
        /// 当期本金罚息
        /// </summary>
        [JsonPropertyName("term_ovd_prin_pen_int")]
        public string TermOvdPrinPenInt { get; set; }

        /// <summary>
        /// 本期开始日
        /// </summary>
        [JsonPropertyName("term_start_date")]
        public string TermStartDate { get; set; }
    }
}
