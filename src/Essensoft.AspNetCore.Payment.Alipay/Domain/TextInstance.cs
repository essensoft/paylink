using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TextInstance Data Structure.
    /// </summary>
    [Serializable]
    public class TextInstance : AlipayObject
    {
        /// <summary>
        /// 元素C端渲染关联位置key值
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// 物料元素类型，TITLE-标题；DESC-描述
        /// </summary>
        [JsonProperty("material_type")]
        public string MaterialType { get; set; }

        /// <summary>
        /// 标题/描述文本值
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
