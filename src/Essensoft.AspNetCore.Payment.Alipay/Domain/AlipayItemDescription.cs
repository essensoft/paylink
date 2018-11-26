using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayItemDescription Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayItemDescription : AlipayObject
    {
        /// <summary>
        /// 标题下的描述列表
        /// </summary>
        [JsonProperty("details")]
        [XmlArray("details")]
        [XmlArrayItem("string")]
        public List<string> Details { get; set; }

        /// <summary>
        /// 明细图片列表，要求图片张数小于或等于3。请勿上传过大图片，图片将会自适应至尺寸比例88:75
        /// </summary>
        [JsonProperty("images")]
        [XmlArray("images")]
        [XmlArrayItem("string")]
        public List<string> Images { get; set; }

        /// <summary>
        /// 描述标题，不得超过15个中文字符
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 套餐使用说明链接，必须是https的地址链接
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
