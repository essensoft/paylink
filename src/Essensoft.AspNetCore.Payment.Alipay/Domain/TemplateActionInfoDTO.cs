using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateActionInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateActionInfoDTO : AlipayObject
    {
        /// <summary>
        /// 行动点业务CODE，商户自定义
        /// </summary>
        [JsonProperty("code")]
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 行动点展示文案
        /// </summary>
        [JsonProperty("text")]
        [XmlElement("text")]
        public string Text { get; set; }

        /// <summary>
        /// 行动点跳转链接
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
