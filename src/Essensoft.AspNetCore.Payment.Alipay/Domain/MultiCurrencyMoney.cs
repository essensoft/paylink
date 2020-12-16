using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MultiCurrencyMoney Data Structure.
    /// </summary>
    public class MultiCurrencyMoney : AlipayObject
    {
        /// <summary>
        /// 金额，默认单位是人民币，精确到小数点两位..
        /// </summary>
        [JsonPropertyName("amt")]
        public string Amt { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }
    }
}
