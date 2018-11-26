using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RetailItemDescription Data Structure.
    /// </summary>
    [Serializable]
    public class RetailItemDescription : AlipayObject
    {
        /// <summary>
        /// 标题下的描述列表，列表类型，每项不得超过100个中文字符,最多10项
        /// </summary>
        [JsonProperty("details")]
        [XmlArray("details")]
        [XmlArrayItem("string")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 商品描述title
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
