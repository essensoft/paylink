using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Picture Data Structure.
    /// </summary>
    [Serializable]
    public class Picture : AlipayObject
    {
        /// <summary>
        /// 调用alipay.offline.material.image.upload接口将图片上传到素材中心后，生成的ID
        /// </summary>
        [JsonProperty("location")]
        [XmlElement("location")]
        public string Location { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
