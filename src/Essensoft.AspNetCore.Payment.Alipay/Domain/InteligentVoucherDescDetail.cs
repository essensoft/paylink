using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InteligentVoucherDescDetail Data Structure.
    /// </summary>
    [Serializable]
    public class InteligentVoucherDescDetail : AlipayObject
    {
        /// <summary>
        /// 具体描述信息列表
        /// </summary>
        [JsonProperty("details")]
        [XmlElement("details")]
        public string Details { get; set; }

        /// <summary>
        /// 图片描述信息
        /// </summary>
        [JsonProperty("images")]
        [XmlElement("images")]
        public string Images { get; set; }

        /// <summary>
        /// 券说明的标题
        /// </summary>
        [JsonProperty("title")]
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 券外部详情描述
        /// </summary>
        [JsonProperty("url")]
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
