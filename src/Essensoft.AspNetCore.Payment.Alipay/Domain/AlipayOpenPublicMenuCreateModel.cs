using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMenuCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicMenuCreateModel : AlipayObject
    {
        /// <summary>
        /// 一级菜单列表。如果是文本菜单，最多有4个一级菜单，若开发者在后台打开了"咨询反馈"的开关，则只能有3个一级菜单；如果是 ICON 菜单信息，最多有80个一级菜单(忽略二级菜单)
        /// </summary>
        [JsonPropertyName("button")]
        public List<ButtonObject> Button { get; set; }

        /// <summary>
        /// 菜单类型，支持值为icon：icon型菜单，text：文本型菜单，不传时默认为"text"，当传值为"icon"时，菜单节点的icon字段必传。
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
