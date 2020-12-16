using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayAccountCashpoolCreateResponse.
    /// </summary>
    public class AlipayAccountCashpoolCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 资金池唯一标志
        /// </summary>
        [JsonPropertyName("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// 资金池名称回显
        /// </summary>
        [JsonPropertyName("cash_pool_name")]
        public string CashPoolName { get; set; }
    }
}
