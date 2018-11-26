using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SceneDetail : AlipayObject
    {
        /// <summary>
        /// 场景描述
        /// </summary>
        [JsonProperty("desc")]
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 场景id
        /// </summary>
        [JsonProperty("scene_id")]
        [XmlElement("scene_id")]
        public string SceneId { get; set; }

        /// <summary>
        /// 场景配置的图片
        /// </summary>
        [JsonProperty("scene_image")]
        [XmlElement("scene_image")]
        public string SceneImage { get; set; }

        /// <summary>
        /// 小蚂答场景标题
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
