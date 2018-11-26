using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NewsfeedMediaImg Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedMediaImg : AlipayObject
    {
        /// <summary>
        /// 图片高度
        /// </summary>
        [JsonProperty("height")]
        [XmlElement("height")]
        public string Height { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        [JsonProperty("src")]
        [XmlElement("src")]
        public string Src { get; set; }

        /// <summary>
        /// 图片宽度
        /// </summary>
        [JsonProperty("width")]
        [XmlElement("width")]
        public string Width { get; set; }
    }
}
