using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneMarketingHeader Data Structure.
    /// </summary>
    [Serializable]
    public class SceneMarketingHeader : AlipayObject
    {
        /// <summary>
        /// 图标地址
        /// </summary>
        [JsonProperty("icon")]
        [XmlElement("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// 子标题
        /// </summary>
        [JsonProperty("sub_title")]
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 简要描述
        /// </summary>
        [JsonProperty("summary")]
        [XmlElement("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("tags")]
        [XmlArray("tags")]
        [XmlArrayItem("string")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 跳转地址
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
