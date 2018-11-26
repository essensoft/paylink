using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExtCategory Data Structure.
    /// </summary>
    [Serializable]
    public class ExtCategory : AlipayObject
    {
        /// <summary>
        /// 品类编码
        /// </summary>
        [JsonProperty("category_code")]
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 品类名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父品类编码。顶级类目此值为0
        /// </summary>
        [JsonProperty("parent_id")]
        [XmlElement("parent_id")]
        public string ParentId { get; set; }
    }
}
