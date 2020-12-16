using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SubAccountBalanceOpenApiDTO Data Structure.
    /// </summary>
    public class SubAccountBalanceOpenApiDTO : AlipayObject
    {
        /// <summary>
        /// 可用余额
        /// </summary>
        [JsonPropertyName("available_amount")]
        public MultiCurrencyMoneyOpenApi AvailableAmount { get; set; }

        /// <summary>
        /// 余额
        /// </summary>
        [JsonPropertyName("balance")]
        public MultiCurrencyMoneyOpenApi Balance { get; set; }

        /// <summary>
        /// 冻结金额
        /// </summary>
        [JsonPropertyName("freeze_amount")]
        public MultiCurrencyMoneyOpenApi FreezeAmount { get; set; }
    }
}
