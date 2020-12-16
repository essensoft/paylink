using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolRuleModifyModel Data Structure.
    /// </summary>
    public class AlipayAccountCashpoolRuleModifyModel : AlipayObject
    {
        /// <summary>
        /// 资金池唯一标识
        /// </summary>
        [JsonPropertyName("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// 机构自定义备注配置
        /// </summary>
        [JsonPropertyName("inst_rule_custom_memo")]
        public InstRuleCustomMemoVO InstRuleCustomMemo { get; set; }

        /// <summary>
        /// 限额水位线
        /// </summary>
        [JsonPropertyName("limit_walter_line")]
        public string LimitWalterLine { get; set; }

        /// <summary>
        /// 是否需要自定义备注
        /// </summary>
        [JsonPropertyName("need_custom_memo")]
        public bool NeedCustomMemo { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 规则唯一标识
        /// </summary>
        [JsonPropertyName("rule_id")]
        public string RuleId { get; set; }

        /// <summary>
        /// RUN/STOP，运行态/暂停态
        /// </summary>
        [JsonPropertyName("rule_status")]
        public string RuleStatus { get; set; }

        /// <summary>
        /// UP_WARD_RULE/DOWN_WARD_RULE，资金上划/下拨
        /// </summary>
        [JsonPropertyName("rule_type")]
        public string RuleType { get; set; }

        /// <summary>
        /// 目标水位线
        /// </summary>
        [JsonPropertyName("target_walter_line")]
        public string TargetWalterLine { get; set; }
    }
}
