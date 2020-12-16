using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAccountCashpoolDetailQueryResponse.
    /// </summary>
    public class AlipayAccountCashpoolDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 资金池详情，包含规则组信息、规则信息、账户关联信息
        /// </summary>
        [JsonPropertyName("cash_pool_detail")]
        public string CashPoolDetail { get; set; }
    }
}
