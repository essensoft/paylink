using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseContentlibNewsflashSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseContentlibNewsflashSendModel : AlipayObject
    {
        /// <summary>
        /// 作者
        /// </summary>
        [JsonProperty("author")]
        [XmlElement("author")]
        public string Author { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        [JsonProperty("content")]
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 扩展信息，json格式数据
        /// </summary>
        [JsonProperty("ext_info")]
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 配图地址
        /// </summary>
        [JsonProperty("images")]
        [XmlElement("images")]
        public string Images { get; set; }

        /// <summary>
        /// 标签, 多个用逗号隔开
        /// </summary>
        [JsonProperty("opr_tags")]
        [XmlElement("opr_tags")]
        public string OprTags { get; set; }

        /// <summary>
        /// 发布时间
        /// </summary>
        [JsonProperty("publish_date")]
        [XmlElement("publish_date")]
        public string PublishDate { get; set; }

        /// <summary>
        /// 推荐权重，0：不可用，1：显示，2：加权
        /// </summary>
        [JsonProperty("recommend")]
        [XmlElement("recommend")]
        public long Recommend { get; set; }

        /// <summary>
        /// 来源渠道
        /// </summary>
        [JsonProperty("source_channel_key")]
        [XmlElement("source_channel_key")]
        public string SourceChannelKey { get; set; }

        /// <summary>
        /// 快讯来源id
        /// </summary>
        [JsonProperty("source_id")]
        [XmlElement("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        [JsonProperty("summary")]
        [XmlElement("summary")]
        public string Summary { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
