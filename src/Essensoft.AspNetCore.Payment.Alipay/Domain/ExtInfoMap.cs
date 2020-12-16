using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtInfoMap Data Structure.
    /// </summary>
    public class ExtInfoMap : AlipayObject
    {
        /// <summary>
        /// 键值对的key，{"orderId":"123456"}中的orderId
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 键值对的value，{"orderId":"123456"} 中的123456
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
