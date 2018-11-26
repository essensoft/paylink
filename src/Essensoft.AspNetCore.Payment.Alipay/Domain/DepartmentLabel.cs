using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DepartmentLabel Data Structure.
    /// </summary>
    [Serializable]
    public class DepartmentLabel : AlipayObject
    {
        /// <summary>
        /// 部门标签码
        /// </summary>
        [JsonProperty("code")]
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 部门标签id
        /// </summary>
        [JsonProperty("label_id")]
        [XmlElement("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 部门标签名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
