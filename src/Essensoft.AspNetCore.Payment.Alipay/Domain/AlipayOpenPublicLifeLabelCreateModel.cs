using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLifeLabelCreateModel : AlipayObject
    {
        /// <summary>
        /// 标签值类型，目前只支持string（字符串类型），不传默认为"string"
        /// </summary>
        [JsonProperty("data_type")]
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 自定义标签名
        /// </summary>
        [JsonProperty("label_name")]
        [XmlElement("label_name")]
        public string LabelName { get; set; }
    }
}
