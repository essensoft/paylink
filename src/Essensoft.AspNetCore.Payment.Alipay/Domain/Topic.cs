using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Topic Data Structure.
    /// </summary>
    [Serializable]
    public class Topic : AlipayObject
    {
        /// <summary>
        /// 营销位图片url
        /// </summary>
        [JsonProperty("img_url")]
        [XmlElement("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 营销位跳转地址，点击营销位头图跳到的链接url。
        /// </summary>
        [JsonProperty("link_url")]
        [XmlElement("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 营销位描述
        /// </summary>
        [JsonProperty("sub_title")]
        [XmlElement("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 营销位名称
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 营销位id
        /// </summary>
        [JsonProperty("topic_id")]
        [XmlElement("topic_id")]
        public string TopicId { get; set; }

        /// <summary>
        /// 营销位内容列表
        /// </summary>
        [JsonProperty("topic_items")]
        [XmlArray("topic_items")]
        [XmlArrayItem("topic_item")]
        public List<TopicItem> TopicItems { get; set; }
    }
}
