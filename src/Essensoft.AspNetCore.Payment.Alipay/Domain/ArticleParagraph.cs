using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArticleParagraph Data Structure.
    /// </summary>
    [Serializable]
    public class ArticleParagraph : AlipayObject
    {
        /// <summary>
        /// 图片列表
        /// </summary>
        [JsonProperty("pictures")]
        [XmlArray("pictures")]
        [XmlArrayItem("article_picture")]
        public List<ArticlePicture> Pictures { get; set; }

        /// <summary>
        /// 文章正文描述
        /// </summary>
        [JsonProperty("text")]
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
