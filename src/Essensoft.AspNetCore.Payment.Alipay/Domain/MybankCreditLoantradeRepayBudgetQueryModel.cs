using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradeRepayBudgetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeRepayBudgetQueryModel : AlipayObject
    {
        /// <summary>
        /// 申请还款金额，如果budget_type为TOTAL_AMT，则填写还款总金额，如果为PRIN_AMT则填写还款本金
        /// </summary>
        [JsonProperty("apply_repay_prin")]
        public string ApplyRepayPrin { get; set; }

        /// <summary>
        /// TOTAL_AMT：总额试算 PRIN_AMT：本金试算 CLEAR_AMT：结清试算 如果为空，默认为本金还款
        /// </summary>
        [JsonProperty("budget_type")]
        public string BudgetType { get; set; }

        /// <summary>
        /// 可为空，默认需要判断是否可还款，false为不需要判断是否可还款，其他为需要判断是否可还款
        /// </summary>
        [JsonProperty("can_repay_flag")]
        public bool CanRepayFlag { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("ext_data")]
        public string ExtData { get; set; }

        /// <summary>
        /// 银行参与者id，是在网商银行创建会员后生成的id，网商银行会员的唯一标识
        /// </summary>
        [JsonProperty("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 银行参与者角色id，是在网商银行创建会员后生成的角色id，网商银行会员角色的唯一标识
        /// </summary>
        [JsonProperty("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 贷款合约编号
        /// </summary>
        [JsonProperty("loan_ar_no")]
        public string LoanArNo { get; set; }

        /// <summary>
        /// 还款场景， 主动还款 CUST_REPAY 机构代客还款 ORG_REPAY 默认值为主动还款
        /// </summary>
        [JsonProperty("repay_scene")]
        public string RepayScene { get; set; }
    }
}
