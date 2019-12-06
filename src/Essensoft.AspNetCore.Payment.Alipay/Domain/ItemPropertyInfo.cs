using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemPropertyInfo Data Structure.
    /// </summary>
    public class ItemPropertyInfo : AlipayObject
    {
        /// <summary>
        /// 属性名称
        /// </summary>
        [JsonPropertyName("property_key")]
        public string PropertyKey { get; set; }

        /// <summary>
        /// 属性值列表
        /// </summary>
        [JsonPropertyName("property_value_list")]
        public List<string> PropertyValueList { get; set; }
    }
}
