using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TextInstance Data Structure.
    /// </summary>
    public class TextInstance : AlipayObject
    {
        /// <summary>
        /// 元素C端渲染关联位置key值
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 物料元素类型，TITLE-标题；DESC-描述
        /// </summary>
        [JsonPropertyName("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 标题/描述文本值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
