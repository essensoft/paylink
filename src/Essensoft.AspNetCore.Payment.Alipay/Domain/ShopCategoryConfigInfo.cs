using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopCategoryConfigInfo Data Structure.
    /// </summary>
    public class ShopCategoryConfigInfo : AlipayObject
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 是否是叶子节点
        /// </summary>
        [JsonPropertyName("is_leaf")]
        public string IsLeaf { get; set; }

        /// <summary>
        /// 类目层级
        /// </summary>
        [JsonPropertyName("level")]
        public string Level { get; set; }

        /// <summary>
        /// 类目层级路径
        /// </summary>
        [JsonPropertyName("link")]
        public string Link { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [JsonPropertyName("nm")]
        public string Nm { get; set; }
    }
}
