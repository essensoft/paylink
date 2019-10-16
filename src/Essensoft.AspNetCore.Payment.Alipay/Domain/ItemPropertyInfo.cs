using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemPropertyInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemPropertyInfo : AlipayObject
    {
        /// <summary>
        /// 属性名称
        /// </summary>
        [JsonProperty("property_key")]
        public string PropertyKey { get; set; }

        /// <summary>
        /// 属性值列表
        /// </summary>
        [JsonProperty("property_value_list")]
        public List<string> PropertyValueList { get; set; }
    }
}
