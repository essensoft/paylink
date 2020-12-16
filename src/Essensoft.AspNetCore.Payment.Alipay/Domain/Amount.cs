using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Amount Data Structure.
    /// </summary>
    public class Amount : AlipayObject
    {
        /// <summary>
        /// 3位币种Code，遵循ISO 4217
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 表示在最小货币单位中代表多少费用的正整数。
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
