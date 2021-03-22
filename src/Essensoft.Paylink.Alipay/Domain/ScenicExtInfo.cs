using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ScenicExtInfo Data Structure.
    /// </summary>
    public class ScenicExtInfo : AlipayObject
    {
        /// <summary>
        /// key的值
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// value值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
