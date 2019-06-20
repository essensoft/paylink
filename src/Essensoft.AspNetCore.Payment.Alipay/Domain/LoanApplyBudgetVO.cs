using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LoanApplyBudgetVO Data Structure.
    /// </summary>
    [Serializable]
    public class LoanApplyBudgetVO : AlipayObject
    {
        /// <summary>
        /// 贷款申请金额
        /// </summary>
        [JsonProperty("apply_amt")]
        public string ApplyAmt { get; set; }

        /// <summary>
        /// 申请时间，即用户提交贷款申请的时间
        /// </summary>
        [JsonProperty("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 贷款申请受理单号
        /// </summary>
        [JsonProperty("apply_receipt_no")]
        public string ApplyReceiptNo { get; set; }

        /// <summary>
        /// 还款预算
        /// </summary>
        [JsonProperty("budget")]
        public BudgetVO Budget { get; set; }

        /// <summary>
        /// 当前期次
        /// </summary>
        [JsonProperty("current_term")]
        public long CurrentTerm { get; set; }

        /// <summary>
        /// 当前期次的还款日
        /// </summary>
        [JsonProperty("current_term_repay_date")]
        public string CurrentTermRepayDate { get; set; }

        /// <summary>
        /// 贷款期限，包含贷款期数和期数单位
        /// </summary>
        [JsonProperty("loan_term")]
        public LoanTerm LoanTerm { get; set; }

        /// <summary>
        /// 贷后还款分期计划
        /// </summary>
        [JsonProperty("repay_plan_term_list")]
        public List<RepayPlanTermVO> RepayPlanTermList { get; set; }
    }
}
