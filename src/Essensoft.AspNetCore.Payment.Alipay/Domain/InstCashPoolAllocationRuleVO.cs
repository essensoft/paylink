using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InstCashPoolAllocationRuleVO Data Structure.
    /// </summary>
    public class InstCashPoolAllocationRuleVO : AlipayObject
    {
        /// <summary>
        /// 机构账号
        /// </summary>
        [JsonPropertyName("inst_account")]
        public InstAccountDTO InstAccount { get; set; }

        /// <summary>
        /// 机构自定义备注
        /// </summary>
        [JsonPropertyName("inst_rule_custom_memo")]
        public InstRuleCustomMemoVO InstRuleCustomMemo { get; set; }

        /// <summary>
        /// 限额水位
        /// </summary>
        [JsonPropertyName("limit_water_line")]
        public string LimitWaterLine { get; set; }

        /// <summary>
        /// 规则备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 是否需要自定义备注
        /// </summary>
        [JsonPropertyName("need_custom_memo")]
        public bool NeedCustomMemo { get; set; }

        /// <summary>
        /// 操作员名称
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 父机构类型
        /// </summary>
        [JsonPropertyName("parent_inst_account")]
        public InstAccountDTO ParentInstAccount { get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonPropertyName("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 规则优先级
        /// </summary>
        [JsonPropertyName("rule_order")]
        public long RuleOrder { get; set; }

        /// <summary>
        /// INITIAL/RUN/STOP，初始态/运行态/暂停态
        /// </summary>
        [JsonPropertyName("rule_status")]
        public string RuleStatus { get; set; }

        /// <summary>
        /// 上划规则/下拨规则，UP_WARD_RULE/DOWN_WARD_RULE
        /// </summary>
        [JsonPropertyName("rule_type")]
        public string RuleType { get; set; }

        /// <summary>
        /// 目标水位线
        /// </summary>
        [JsonPropertyName("target_water_line")]
        public string TargetWaterLine { get; set; }
    }
}
