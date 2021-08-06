using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BusinessRelationExtInfo Data Structure.
    /// </summary>
    public class BusinessRelationExtInfo : AlipayObject
    {
        /// <summary>
        /// KV数据对的key，表示该kv对象表示什么含义。
        /// </summary>
        [JsonPropertyName("key_name")]
        public string KeyName { get; set; }

        /// <summary>
        /// kv对象的值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
