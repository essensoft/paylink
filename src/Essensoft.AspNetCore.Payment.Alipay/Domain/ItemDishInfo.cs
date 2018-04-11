using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemDishInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDishInfo : AlipayObject
    {
        /// <summary>
        /// 商品详情-菜品图片中的图片描述
        /// </summary>
        [JsonProperty("desc")]
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 详情图片中，菜品图片列表
        /// </summary>
        [JsonProperty("image_urls")]
        [XmlArray("image_urls")]
        [XmlArrayItem("string")]
        public List<string> ImageUrls { get; set; }

        /// <summary>
        /// 详情图片中，菜品标题。请勿超过15汉字，30个字符
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
