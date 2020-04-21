using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanLoanDetailQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanLoanDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 贷款申请金额
        /// </summary>
        [JsonPropertyName("apply_amt")]
        public string ApplyAmt { get; set; }

        /// <summary>
        /// 申请时间，即用户提交贷款申请时间
        /// </summary>
        [JsonPropertyName("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 贷款结清时间
        /// </summary>
        [JsonPropertyName("clear_date")]
        public string ClearDate { get; set; }

        /// <summary>
        /// 签署合同类型列表，取值{LOAN}：LOAN-贷款合同;
        /// </summary>
        [JsonPropertyName("contract_type_list")]
        public List<string> ContractTypeList { get; set; }

        /// <summary>
        /// 扩展变量
        /// </summary>
        [JsonPropertyName("ext_variable")]
        public string ExtVariable { get; set; }

        /// <summary>
        /// 贷款期限，包含贷款期数和期数单位
        /// </summary>
        [JsonPropertyName("loan_term")]
        public LoanTerm LoanTerm { get; set; }

        /// <summary>
        /// 贷款连续逾期天数=max{本金连续逾期天数，利息连续逾期天数}
        /// </summary>
        [JsonPropertyName("ovd_day_num")]
        public long OvdDayNum { get; set; }

        /// <summary>
        /// 累计已还利息
        /// </summary>
        [JsonPropertyName("paid_int")]
        public string PaidInt { get; set; }

        /// <summary>
        /// 累计已还逾期利息罚息
        /// </summary>
        [JsonPropertyName("paid_ovd_int_penalty")]
        public string PaidOvdIntPenalty { get; set; }

        /// <summary>
        /// 累计已还逾期本金罚息
        /// </summary>
        [JsonPropertyName("paid_ovd_prin_penalty")]
        public string PaidOvdPrinPenalty { get; set; }

        /// <summary>
        /// 累计已还本金
        /// </summary>
        [JsonPropertyName("paid_prin")]
        public string PaidPrin { get; set; }

        /// <summary>
        /// 剩余应还总额
        /// </summary>
        [JsonPropertyName("remain_repay_amt")]
        public string RemainRepayAmt { get; set; }

        /// <summary>
        /// 剩余应还利息
        /// </summary>
        [JsonPropertyName("remain_repay_int_amt")]
        public string RemainRepayIntAmt { get; set; }

        /// <summary>
        /// 剩余应还本金
        /// </summary>
        [JsonPropertyName("remain_repay_prin_amt")]
        public string RemainRepayPrinAmt { get; set; }

        /// <summary>
        /// 还款方式，取值{1, 3, 6}：1-等额本息; 3-按期付息到期还本;  6-到期一次性还本付息;
        /// </summary>
        [JsonPropertyName("repay_mode")]
        public string RepayMode { get; set; }

        /// <summary>
        /// 贷后还款分期计划
        /// </summary>
        [JsonPropertyName("repay_plan_term_list")]
        public List<RepayPlanTermVO> RepayPlanTermList { get; set; }

        /// <summary>
        /// 贷款开始时间，即贷款生效时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 贷款申请状态，取值{SUBMITTED, LENDING, USING, OVD, CLEAR, FAILED}：SUBMITTED-已提交; LENDING-放款中; USING-使用中; OVD-已逾期; CLEAR-已结清; FAILED-已失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
