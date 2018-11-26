using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CustomerEntity Data Structure.
    /// </summary>
    [Serializable]
    public class CustomerEntity : AlipayObject
    {
        /// <summary>
        /// 实体英文名
        /// </summary>
        [JsonProperty("code")]
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 实体描述
        /// </summary>
        [JsonProperty("desc")]
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 实体id
        /// </summary>
        [JsonProperty("id")]
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 实体中文名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// tag列表
        /// </summary>
        [JsonProperty("tags")]
        [XmlArray("tags")]
        [XmlArrayItem("customer_tag")]
        public List<CustomerTag> Tags { get; set; }
    }
}
