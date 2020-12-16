using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAccountCashpoolAllocateruleCreateResponse.
    /// </summary>
    public class AlipayAccountCashpoolAllocateruleCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 新增规则ID
        /// </summary>
        [JsonPropertyName("rule_id")]
        public long RuleId { get; set; }
    }
}
