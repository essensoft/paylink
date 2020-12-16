using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemProperty Data Structure.
    /// </summary>
    public class ItemProperty : AlipayObject
    {
        /// <summary>
        /// 属性；内容不能有空格
        /// </summary>
        [JsonPropertyName("prop_key")]
        public string PropKey { get; set; }

        /// <summary>
        /// 属性值；内容不能有空格
        /// </summary>
        [JsonPropertyName("prop_values")]
        public List<string> PropValues { get; set; }
    }
}
