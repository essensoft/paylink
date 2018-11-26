using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CaptchaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CaptchaInfo : AlipayObject
    {
        /// <summary>
        /// 图片特殊描述信息
        /// </summary>
        [JsonProperty("captcha_desc")]
        [XmlElement("captcha_desc")]
        public string CaptchaDesc { get; set; }

        /// <summary>
        /// 图片内容，base64编码
        /// </summary>
        [JsonProperty("image_content")]
        [XmlElement("image_content")]
        public string ImageContent { get; set; }

        /// <summary>
        /// 图片类型，jpeg|bmp
        /// </summary>
        [JsonProperty("image_type")]
        [XmlElement("image_type")]
        public string ImageType { get; set; }
    }
}
