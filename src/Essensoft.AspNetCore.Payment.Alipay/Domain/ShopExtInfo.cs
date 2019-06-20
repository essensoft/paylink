using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopExtInfo : AlipayObject
    {
        /// <summary>
        /// KV数据对的key，表示该kv对象表示什么含义。
        /// </summary>
        [JsonProperty("key_name")]
        public string KeyName { get; set; }

        /// <summary>
        /// kv对象的值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
