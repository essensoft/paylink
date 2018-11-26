using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CategoryLevelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CategoryLevelInfo : AlipayObject
    {
        /// <summary>
        /// 品类编码
        /// </summary>
        [JsonProperty("category_code")]
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 品类级别
        /// </summary>
        [JsonProperty("category_level")]
        [XmlElement("category_level")]
        public long CategoryLevel { get; set; }

        /// <summary>
        /// 品类名称
        /// </summary>
        [JsonProperty("category_name")]
        [XmlElement("category_name")]
        public string CategoryName { get; set; }
    }
}
