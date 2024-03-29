﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ExpenseCtrRuleGroupInfo Data Structure.
    /// </summary>
    public class ExpenseCtrRuleGroupInfo : AlipayObject
    {
        /// <summary>
        /// 费控规则列表
        /// </summary>
        [JsonPropertyName("expense_ctrl_rule_info_list")]
        public List<ExpenseCtrRuleInfo> ExpenseCtrlRuleInfoList { get; set; }

        /// <summary>
        /// 费用类型（餐饮：MEAL  ，地铁：METRO  ，通用：DEFAULT ）
        /// </summary>
        [JsonPropertyName("expense_type")]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 规则组id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 规则组名称
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }
    }
}
