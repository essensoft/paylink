using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Image Data Structure.
    /// </summary>
    [Serializable]
    public class Image : AlipayObject
    {
        /// <summary>
        /// 图片url，请先调用alipay.offline.material.image.upload 图片上传接口获得图片url
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
