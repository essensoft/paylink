using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemSkuPropertyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemSkuPropertyInfo : AlipayObject
    {
        /// <summary>
        /// 属性
        /// </summary>
        [JsonProperty("property_key")]
        public string PropertyKey { get; set; }

        /// <summary>
        /// 属性值
        /// </summary>
        [JsonProperty("property_value")]
        public string PropertyValue { get; set; }
    }
}
