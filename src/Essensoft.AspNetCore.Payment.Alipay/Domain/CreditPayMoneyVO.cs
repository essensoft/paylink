using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CreditPayMoneyVO Data Structure.
    /// </summary>
    public class CreditPayMoneyVO : AlipayObject
    {
        /// <summary>
        /// 金额，单位元
        /// </summary>
        [JsonPropertyName("amt")]
        public string Amt { get; set; }

        /// <summary>
        /// 币种代码
        /// </summary>
        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }
    }
}
