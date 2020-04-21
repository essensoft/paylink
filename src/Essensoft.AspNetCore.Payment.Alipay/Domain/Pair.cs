using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Pair Data Structure.
    /// </summary>
    public class Pair : AlipayObject
    {
        /// <summary>
        /// KEY
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// value
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
