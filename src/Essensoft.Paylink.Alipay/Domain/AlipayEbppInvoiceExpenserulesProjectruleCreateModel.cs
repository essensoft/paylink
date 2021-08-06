using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpenserulesProjectruleCreateModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceExpenserulesProjectruleCreateModel : AlipayObject
    {
        /// <summary>
        /// 企业签约企业合花ID-共同账号ID
        /// </summary>
        [JsonPropertyName("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [JsonPropertyName("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 有效期截止（yyyy-MM-dd HH:mm:ss，必须大于起始时间）
        /// </summary>
        [JsonPropertyName("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 有效期起始（yyyy-MM-dd HH:mm:ss，必须小于截止时间）
        /// </summary>
        [JsonPropertyName("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 员工支付宝id列表（最大长度为50）
        /// </summary>
        [JsonPropertyName("employee_list")]
        public List<string> EmployeeList { get; set; }

        /// <summary>
        /// 规则组列表
        /// </summary>
        [JsonPropertyName("expense_ctrl_rule_info_group_list")]
        public List<ExpenseCtrRuleGroupInfo> ExpenseCtrlRuleInfoGroupList { get; set; }

        /// <summary>
        /// 项目名称（相同account_id下不可重复）
        /// </summary>
        [JsonPropertyName("project_name")]
        public string ProjectName { get; set; }
    }
}
