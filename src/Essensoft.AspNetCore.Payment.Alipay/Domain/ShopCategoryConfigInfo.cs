using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopCategoryConfigInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ShopCategoryConfigInfo : AlipayObject
    {
        /// <summary>
        /// 类目ID
        /// </summary>
        [JsonProperty("id")]
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 是否是叶子节点
        /// </summary>
        [JsonProperty("is_leaf")]
        [XmlElement("is_leaf")]
        public string IsLeaf { get; set; }

        /// <summary>
        /// 类目层级
        /// </summary>
        [JsonProperty("level")]
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 类目层级路径
        /// </summary>
        [JsonProperty("link")]
        [XmlElement("link")]
        public string Link { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        [JsonProperty("nm")]
        [XmlElement("nm")]
        public string Nm { get; set; }
    }
}
