using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TreeData Data Structure.
    /// </summary>
    [Serializable]
    public class TreeData : AlipayObject
    {
        /// <summary>
        /// 是否合种。true：是合种，false：不是合种
        /// </summary>
        [JsonProperty("cooperation")]
        public bool Cooperation { get; set; }

        /// <summary>
        /// 当前分类下已种植树数量，如：合种胡杨1棵，个人种植胡杨1棵
        /// </summary>
        [JsonProperty("num")]
        public long Num { get; set; }

        /// <summary>
        /// 树种别名
        /// </summary>
        [JsonProperty("tree_alias")]
        public string TreeAlias { get; set; }

        /// <summary>
        /// 树种类型，保护地【RESERVE】还是树苗【TREE】
        /// </summary>
        [JsonProperty("tree_type")]
        public string TreeType { get; set; }
    }
}
