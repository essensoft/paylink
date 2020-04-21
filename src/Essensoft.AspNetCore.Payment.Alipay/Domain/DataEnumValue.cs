using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DataEnumValue Data Structure.
    /// </summary>
    public class DataEnumValue : AlipayObject
    {
        /// <summary>
        /// 过滤条件
        /// </summary>
        [JsonPropertyName("filter_tags")]
        public List<FilterTag> FilterTags { get; set; }

        /// <summary>
        /// 枚举的展示文本
        /// </summary>
        [JsonPropertyName("label")]
        public string Label { get; set; }

        /// <summary>
        /// 自定义标签的枚举值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
