using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// QueryComplexLabelRule Data Structure.
    /// </summary>
    [Serializable]
    public class QueryComplexLabelRule : AlipayObject
    {
        /// <summary>
        /// 标签id
        /// </summary>
        [JsonProperty("label_id")]
        [XmlElement("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        [JsonProperty("label_name")]
        [XmlElement("label_name")]
        public string LabelName { get; set; }

        /// <summary>
        /// 当有多个取值时用英文","分隔，不允许传入下划线"_"、竖线"|"或者空格" "
        /// </summary>
        [JsonProperty("label_value")]
        [XmlElement("label_value")]
        public string LabelValue { get; set; }

        /// <summary>
        /// 运算符
        /// </summary>
        [JsonProperty("operator")]
        [XmlElement("operator")]
        public string Operator { get; set; }
    }
}
