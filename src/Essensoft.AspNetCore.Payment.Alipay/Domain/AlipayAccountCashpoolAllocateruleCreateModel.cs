using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolAllocateruleCreateModel Data Structure.
    /// </summary>
    public class AlipayAccountCashpoolAllocateruleCreateModel : AlipayObject
    {
        /// <summary>
        /// 转账规则
        /// </summary>
        [JsonPropertyName("allocation_rule")]
        public InstCashPoolAllocationRuleVO AllocationRule { get; set; }

        /// <summary>
        /// 资金池唯一标识
        /// </summary>
        [JsonPropertyName("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 对应的规则组ID
        /// </summary>
        [JsonPropertyName("rule_group_id")]
        public string RuleGroupId { get; set; }
    }
}
