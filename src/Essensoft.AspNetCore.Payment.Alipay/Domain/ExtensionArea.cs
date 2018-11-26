using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtensionArea Data Structure.
    /// </summary>
    [Serializable]
    public class ExtensionArea : AlipayObject
    {
        /// <summary>
        /// 跳转链接，当content_type为"image"时必传，必须是https或alipays开头的url链接
        /// </summary>
        [JsonProperty("goto_url")]
        [XmlElement("goto_url")]
        public string GotoUrl { get; set; }

        /// <summary>
        /// 扩展区高度，当content_type值为"h5"时必填，取值范围为200-500的整数
        /// </summary>
        [JsonProperty("height")]
        [XmlElement("height")]
        public long Height { get; set; }

        /// <summary>
        /// 扩展区名字
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 扩展区类型，支持两个值，h5：h5类型，image：图片类型。
        /// </summary>
        [JsonProperty("type")]
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 扩展区url，传入图片url或者h5页面url，必须是https开头的链接，如果要传入图片链接，请先调用<a href="https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload"> 图片上传接口</a>获得图片url
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
