using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectrulesModifyModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesProjectrulesModifyModel : AlipayObject
    {
        /// <summary>
        /// 企业id-共同账号ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 修改规则组中的规则明细-MODIFY_RULE
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 规则组列表
        /// </summary>
        [JsonPropertyName("expense_ctrl_rule_info_group_list")]
        public List<ExpenseCtrRuleGroupInfo> ExpenseCtrlRuleInfoGroupList { get; set; }

        /// <summary>
        /// 项目id
        /// </summary>
        [JsonPropertyName("project_id")]
        public string ProjectId { get; set; }
    }
}
