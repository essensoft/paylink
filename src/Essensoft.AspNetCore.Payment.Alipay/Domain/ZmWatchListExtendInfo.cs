using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZmWatchListExtendInfo Data Structure.
    /// </summary>
    public class ZmWatchListExtendInfo : AlipayObject
    {
        /// <summary>
        /// 对于这个key的描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 对应的字段名
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 对应的值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
