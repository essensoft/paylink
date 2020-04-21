using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RateCurrency Data Structure.
    /// </summary>
    public class RateCurrency : AlipayObject
    {
        /// <summary>
        /// 货币编码，ISO标准alpha-3币种编码
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 币种中文名称
        /// </summary>
        [JsonPropertyName("currency_chinese_name")]
        public string CurrencyChineseName { get; set; }

        /// <summary>
        /// 币种图标
        /// </summary>
        [JsonPropertyName("currency_icon")]
        public string CurrencyIcon { get; set; }
    }
}
