using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Article Data Structure.
    /// </summary>
    [Serializable]
    public class Article : AlipayObject
    {
        /// <summary>
        /// 链接文字
        /// </summary>
        [JsonProperty("action_name")]
        [XmlElement("action_name")]
        public string ActionName { get; set; }

        /// <summary>
        /// 图文消息内容
        /// </summary>
        [JsonProperty("desc")]
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 图片链接，对于多条图文消息的第一条消息，该字段不能为空; 请先调用<a href="https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload"> 图片上传接口</a>获得图片url
        /// </summary>
        [JsonProperty("image_url")]
        [XmlElement("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// 图文消息标题
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 点击图文消息跳转的链接
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
