using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Attribute Data Structure.
    /// </summary>
    public class Attribute : AlipayObject
    {
        /// <summary>
        /// 扩展属性的key，由支付宝侧定义分配
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 属性的值，如果“单一值”，数组只有一项；如果是“多值”，则数组对应有多项。
        /// </summary>
        [JsonPropertyName("value")]
        public List<string> Value { get; set; }
    }
}
