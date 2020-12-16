using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolAllocaterulePayModel Data Structure.
    /// </summary>
    public class AlipayAccountCashpoolAllocaterulePayModel : AlipayObject
    {
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
        /// 资金池规则组唯一标识
        /// </summary>
        [JsonPropertyName("rule_group_id")]
        public string RuleGroupId { get; set; }
    }
}
