using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicShortlinkCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicShortlinkCreateModel : AlipayObject
    {
        /// <summary>
        /// 对于场景ID的描述，商户自己定义
        /// </summary>
        [JsonProperty("remark")]
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 短链接对应的场景ID，该ID由商户自己定义
        /// </summary>
        [JsonProperty("scene_id")]
        [XmlElement("scene_id")]
        public string SceneId { get; set; }
    }
}
