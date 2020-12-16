using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountCashpoolDeleteModel Data Structure.
    /// </summary>
    public class AlipayAccountCashpoolDeleteModel : AlipayObject
    {
        /// <summary>
        /// 资金池ID
        /// </summary>
        [JsonPropertyName("cash_pool_id")]
        public string CashPoolId { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }
    }
}
