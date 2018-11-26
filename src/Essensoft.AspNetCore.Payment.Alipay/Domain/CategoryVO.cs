using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CategoryVO Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryVO : AlipayObject
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [JsonProperty("category_id")]
        [XmlElement("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [JsonProperty("category_name")]
        [XmlElement("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 类目描述
        /// </summary>
        [JsonProperty("description")]
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 1表示有效，0表示无效
        /// </summary>
        [JsonProperty("enable")]
        [XmlElement("enable")]
        public long Enable { get; set; }

        /// <summary>
        /// 类目层级
        /// </summary>
        [JsonProperty("level")]
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 父类目ID
        /// </summary>
        [JsonProperty("parent_id")]
        [XmlElement("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// 根类目ID
        /// </summary>
        [JsonProperty("root_id")]
        [XmlElement("root_id")]
        public string RootId { get; set; }
    }
}
