using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TreeData Data Structure.
    /// </summary>
    public class TreeData : AlipayObject
    {
        /// <summary>
        /// 是否合种。true：是合种，false：不是合种
        /// </summary>
        [JsonPropertyName("cooperation")]
        public bool Cooperation { get; set; }

        /// <summary>
        /// 当前分类下已种植树数量，如：合种胡杨1棵，个人种植胡杨1棵
        /// </summary>
        [JsonPropertyName("num")]
        public long Num { get; set; }

        /// <summary>
        /// 树种别名
        /// </summary>
        [JsonPropertyName("tree_alias")]
        public string TreeAlias { get; set; }

        /// <summary>
        /// 树种类型，保护地【RESERVE】还是树苗【TREE】
        /// </summary>
        [JsonPropertyName("tree_type")]
        public string TreeType { get; set; }
    }
}
