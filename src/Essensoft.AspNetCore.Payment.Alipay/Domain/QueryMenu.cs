using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QueryMenu Data Structure.
    /// </summary>
    public class QueryMenu : AlipayObject
    {
        /// <summary>
        /// 一级菜单列表
        /// </summary>
        [JsonPropertyName("button")]
        public List<ButtonObject> Button { get; set; }

        /// <summary>
        /// 标签规则项列表
        /// </summary>
        [JsonPropertyName("label_rule")]
        public List<QueryLabelRule> LabelRule { get; set; }

        /// <summary>
        /// 菜单唯一id
        /// </summary>
        [JsonPropertyName("menu_key")]
        public string MenuKey { get; set; }

        /// <summary>
        /// 菜单类型，icon：icon型菜单，text：文本型菜单
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
