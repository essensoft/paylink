using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanLoanUnclearQueryResponse.
    /// </summary>
    public class AlipayPcreditLoanLoanUnclearQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 贷款申请预算信息列表
        /// </summary>
        [JsonPropertyName("loan_apply_budget_list")]
        public List<LoanApplyBudgetVO> LoanApplyBudgetList { get; set; }

        /// <summary>
        /// 结果总数
        /// </summary>
        [JsonPropertyName("total")]
        public long Total { get; set; }
    }
}
