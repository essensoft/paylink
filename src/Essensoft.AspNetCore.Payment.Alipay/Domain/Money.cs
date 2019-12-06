using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Money Data Structure.
    /// </summary>
    public class Money : AlipayObject
    {
        /// <summary>
        /// 3-letter currency code, refer to ISO 4217 Standard currency alphabetic code
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// amount value
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
