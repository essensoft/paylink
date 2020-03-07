using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LoanRepayPlanTerm Data Structure.
    /// </summary>
    public class LoanRepayPlanTerm : AlipayObject
    {
        /// <summary>
        /// 是否当前期
        /// </summary>
        [JsonPropertyName("current_term")]
        public bool CurrentTerm { get; set; }

        /// <summary>
        /// 当期已还金额
        /// </summary>
        [JsonPropertyName("paid_amt")]
        public LoanMoneyTypeAmt PaidAmt { get; set; }

        /// <summary>
        /// 剩余应还金额
        /// </summary>
        [JsonPropertyName("remain_amt")]
        public LoanMoneyTypeAmt RemainAmt { get; set; }

        /// <summary>
        /// 分期状态，目前支持的分期状态有：  NORMAL: 正常  OVD: 逾期  CLEAR: 结清
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

        /// <summary>
        /// 当期总金额
        /// </summary>
        [JsonPropertyName("total_amt")]
        public LoanMoneyTypeAmt TotalAmt { get; set; }
    }
}
