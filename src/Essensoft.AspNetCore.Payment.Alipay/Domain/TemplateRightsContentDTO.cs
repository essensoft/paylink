using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TemplateRightsContentDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateRightsContentDTO : AlipayObject
    {
        /// <summary>
        /// 权益内容详情
        /// </summary>
        [JsonProperty("detail")]
        [XmlElement("detail")]
        public string Detail { get; set; }

        /// <summary>
        /// 权益内容标题
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }
    }
}
