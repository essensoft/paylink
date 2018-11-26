using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CommonDescInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommonDescInfo : AlipayObject
    {
        /// <summary>
        /// 图片URL地址，最大不超过60K，必须使用https
        /// </summary>
        [JsonProperty("img")]
        [XmlElement("img")]
        public string Img { get; set; }

        /// <summary>
        /// 文本描述
        /// </summary>
        [JsonProperty("text")]
        [XmlElement("text")]
        public string Text { get; set; }
    }
}
