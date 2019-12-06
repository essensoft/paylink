using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MultiCurrencyMoneyOpenApi Data Structure.
    /// </summary>
    public class MultiCurrencyMoneyOpenApi : AlipayObject
    {
        /// <summary>
        /// 分
        /// </summary>
        [JsonPropertyName("cent")]
        public long Cent { get; set; }

        /// <summary>
        /// 币种类型值
        /// </summary>
        [JsonPropertyName("currency_value")]
        public string CurrencyValue { get; set; }
    }
}
