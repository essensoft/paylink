using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishPropertyValueInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishPropertyValueInfo : AlipayObject
    {
        /// <summary>
        /// 属性值排序字段，从1一直递增到5
        /// </summary>
        [JsonProperty("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// 销售属性值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
