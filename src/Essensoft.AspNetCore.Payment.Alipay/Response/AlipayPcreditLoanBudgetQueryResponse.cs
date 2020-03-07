using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanBudgetQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanBudgetQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 贷前还款分期计划列表
        /// </summary>
        [JsonPropertyName("pre_repay_plan_term_list")]
        public List<PreRepayPlanTermVO> PreRepayPlanTermList { get; set; }

        /// <summary>
        /// 应还总额=应还本金+应还利息
        /// </summary>
        [JsonPropertyName("repay_amt_total")]
        public string RepayAmtTotal { get; set; }

        /// <summary>
        /// 应还利息总额
        /// </summary>
        [JsonPropertyName("repay_int_amt_total")]
        public string RepayIntAmtTotal { get; set; }

        /// <summary>
        /// 应还本金总额
        /// </summary>
        [JsonPropertyName("repay_prin_amt_total")]
        public string RepayPrinAmtTotal { get; set; }
    }
}
