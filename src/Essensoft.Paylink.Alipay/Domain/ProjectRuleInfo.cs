using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ProjectRuleInfo Data Structure.
    /// </summary>
    public class ProjectRuleInfo : AlipayObject
    {
        /// <summary>
        /// 有效期截止
        /// </summary>
        [JsonPropertyName("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 有效期起始
        /// </summary>
        [JsonPropertyName("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 员工uid列表
        /// </summary>
        [JsonPropertyName("employee_list")]
        public List<string> EmployeeList { get; set; }

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

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonPropertyName("project_name")]
        public string ProjectName { get; set; }
    }
}
