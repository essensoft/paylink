using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ArticleCategoryInfo Data Structure.
    /// </summary>
    public class ArticleCategoryInfo : AlipayObject
    {
        /// <summary>
        /// 子节点
        /// </summary>
        [JsonPropertyName("children")]
        public List<string> Children { get; set; }

        /// <summary>
        /// 节点描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 父节点ID
        /// </summary>
        [JsonPropertyName("father_id")]
        public long FatherId { get; set; }

        /// <summary>
        /// 类目ID
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonPropertyName("tags")]
        public List<string> Tags { get; set; }
    }
}
