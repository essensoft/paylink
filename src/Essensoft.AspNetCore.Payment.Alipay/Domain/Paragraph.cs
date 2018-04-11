using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Paragraph Data Structure.
    /// </summary>
    [Serializable]
    public class Paragraph : AlipayObject
    {
        /// <summary>
        /// 图片列表
        /// </summary>
        [JsonProperty("pictures")]
        [XmlArray("pictures")]
        [XmlArrayItem("picture")]
        public List<Picture> Pictures { get; set; }

        /// <summary>
        /// 正文介绍
        /// </summary>
        [JsonProperty("text")]
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
