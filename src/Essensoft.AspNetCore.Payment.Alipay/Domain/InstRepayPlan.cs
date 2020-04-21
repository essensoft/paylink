using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InstRepayPlan Data Structure.
    /// </summary>
    public class InstRepayPlan : AlipayObject
    {
        /// <summary>
        /// 是否是当期。 默认值为不是当期计划。如果合约最后一期计划都已经逾期，就不再存在当期计划，合约下所有计划明细的该值都为false
        /// </summary>
        [JsonPropertyName("cur_term")]
        public bool CurTerm { get; set; }

        /// <summary>
        /// 当期利息，单位：元
        /// </summary>
        [JsonPropertyName("cur_term_interest")]
        public string CurTermInterest { get; set; }

        /// <summary>
        /// 当期利息罚息，单位：元
        /// </summary>
        [JsonPropertyName("cur_term_interest_penalty")]
        public string CurTermInterestPenalty { get; set; }

        /// <summary>
        /// 当期本金，单位：元
        /// </summary>
        [JsonPropertyName("cur_term_principal")]
        public string CurTermPrincipal { get; set; }

        /// <summary>
        /// 当期本金罚息，单位：元
        /// </summary>
        [JsonPropertyName("cur_term_principal_penalty")]
        public string CurTermPrincipalPenalty { get; set; }

        /// <summary>
        /// 当期已还利息，单位：元
        /// </summary>
        [JsonPropertyName("repaid_interest")]
        public string RepaidInterest { get; set; }

        /// <summary>
        /// 当期已还利息罚息，单位：元
        /// </summary>
        [JsonPropertyName("repaid_interest_penalty")]
        public string RepaidInterestPenalty { get; set; }

        /// <summary>
        /// 当期已还本金，单位：元
        /// </summary>
        [JsonPropertyName("repaid_principal")]
        public string RepaidPrincipal { get; set; }

        /// <summary>
        /// 当期已还本金罚息，单位：元
        /// </summary>
        [JsonPropertyName("repaid_principal_penalty")]
        public string RepaidPrincipalPenalty { get; set; }

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
        /// 本期开始日
        /// </summary>
        [JsonPropertyName("term_start_date")]
        public string TermStartDate { get; set; }
    }
}
