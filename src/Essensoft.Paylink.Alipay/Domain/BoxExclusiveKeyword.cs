using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// BoxExclusiveKeyword Data Structure.
    /// </summary>
    public class BoxExclusiveKeyword : AlipayObject
    {
        /// <summary>
        /// 默认品牌触发词
        /// </summary>
        [JsonPropertyName("default_keywords")]
        public List<string> DefaultKeywords { get; set; }

        /// <summary>
        /// 自定义品牌触发词
        /// </summary>
        [JsonPropertyName("keywords")]
        public List<string> Keywords { get; set; }
    }
}
