using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IntroductionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IntroductionInfo : AlipayObject
    {
        /// <summary>
        /// 商品详情-商家介绍图片地址列表
        /// </summary>
        [JsonProperty("image_urls")]
        [XmlArray("image_urls")]
        [XmlArrayItem("string")]
        public List<string> ImageUrls { get; set; }

        /// <summary>
        /// 商品详情-商家介绍标题
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
