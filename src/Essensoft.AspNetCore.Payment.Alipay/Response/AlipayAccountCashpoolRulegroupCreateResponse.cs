using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAccountCashpoolRulegroupCreateResponse.
    /// </summary>
    public class AlipayAccountCashpoolRulegroupCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 规则组ID
        /// </summary>
        [JsonPropertyName("rule_group_id")]
        public string RuleGroupId { get; set; }
    }
}
