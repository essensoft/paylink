using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankCreditLoantradeLoanarrangementQueryResponse.
    /// </summary>
    public class MybankCreditLoantradeLoanarrangementQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 合约状态 NORMAL:正常 ,OVD:逾期, CLEAR:结清, LENDING:放款中（未放款确认）
        /// </summary>
        [JsonPropertyName("ar_status")]
        public string ArStatus { get; set; }

        /// <summary>
        /// 初始放款金额（支用金额）, 单位：元
        /// </summary>
        [JsonPropertyName("encash_amt")]
        public string EncashAmt { get; set; }

        /// <summary>
        /// 贷款合约结束日期
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 还款计划
        /// </summary>
        [JsonPropertyName("installment_repay_plans")]
        public List<InstRepayPlan> InstallmentRepayPlans { get; set; }

        /// <summary>
        /// 剩余利息。 单位：元
        /// </summary>
        [JsonPropertyName("interest")]
        public string Interest { get; set; }

        /// <summary>
        /// 利率 若为分段还款，则存储的为分段利率的分段值。否则，该list仅含一个元素，为当前的利率
        /// </summary>
        [JsonPropertyName("interest_rates")]
        public List<InstallmentMetaInfo> InterestRates { get; set; }

        /// <summary>
        /// 合约编号
        /// </summary>
        [JsonPropertyName("loan_ar_no")]
        public string LoanArNo { get; set; }

        /// <summary>
        /// 贷款期限, 包含单位，年(Y)、月(M)、日(D)
        /// </summary>
        [JsonPropertyName("loan_term")]
        public string LoanTerm { get; set; }

        /// <summary>
        /// 逾期天数，若没有逾期则为0，有逾期则为逾期天数
        /// </summary>
        [JsonPropertyName("ovd_days")]
        public string OvdDays { get; set; }

        /// <summary>
        /// 逾期利息罚息，单位：元
        /// </summary>
        [JsonPropertyName("overdue_interest_penalty")]
        public string OverdueInterestPenalty { get; set; }

        /// <summary>
        /// 逾期本金罚息，单位：元
        /// </summary>
        [JsonPropertyName("overdue_principal_penalty")]
        public string OverduePrincipalPenalty { get; set; }

        /// <summary>
        /// 剩余本金。 单位：元
        /// </summary>
        [JsonPropertyName("principal")]
        public string Principal { get; set; }

        /// <summary>
        /// 还款方式。若为分段还款，则存储的为分段还款方式的分段值。否则，该list仅含一个元素，为当前的还款方式
        /// </summary>
        [JsonPropertyName("repay_modes")]
        public List<InstallmentMetaInfo> RepayModes { get; set; }

        /// <summary>
        /// 贷款合约起始日期
        /// </summary>
        [JsonPropertyName("start_date")]
        public List<string> StartDate { get; set; }
    }
}
