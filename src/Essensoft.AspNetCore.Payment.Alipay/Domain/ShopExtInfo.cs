using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopExtInfo Data Structure.
    /// </summary>
    public class ShopExtInfo : AlipayObject
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
