using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CountInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CountInfo : AlipayObject
    {
        /// <summary>
        /// 飞猪内容id
        /// </summary>
        [JsonProperty("content_id")]
        [XmlElement("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        [JsonProperty("support_count")]
        [XmlElement("support_count")]
        public long SupportCount { get; set; }

        /// <summary>
        /// 阅读数
        /// </summary>
        [JsonProperty("total_page_view_count")]
        [XmlElement("total_page_view_count")]
        public long TotalPageViewCount { get; set; }
    }
}
