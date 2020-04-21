using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KeyValuePair Data Structure.
    /// </summary>
    public class KeyValuePair : AlipayObject
    {
        /// <summary>
        /// key
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
