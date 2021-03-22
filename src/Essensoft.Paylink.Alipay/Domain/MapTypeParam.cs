using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// MapTypeParam Data Structure.
    /// </summary>
    public class MapTypeParam : AlipayObject
    {
        /// <summary>
        /// 参数的名字
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数的值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
