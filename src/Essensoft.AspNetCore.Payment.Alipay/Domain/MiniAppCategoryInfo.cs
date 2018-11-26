using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MiniAppCategoryInfo Data Structure.
    /// </summary>
    [Serializable]
    public class MiniAppCategoryInfo : AlipayObject
    {
        /// <summary>
        /// 一级类目id
        /// </summary>
        [JsonProperty("first_category_id")]
        [XmlElement("first_category_id")]
        public string FirstCategoryId { get; set; }

        /// <summary>
        /// 一级类目名称
        /// </summary>
        [JsonProperty("first_category_name")]
        [XmlElement("first_category_name")]
        public string FirstCategoryName { get; set; }

        /// <summary>
        /// 二级类目id
        /// </summary>
        [JsonProperty("second_category_id")]
        [XmlElement("second_category_id")]
        public string SecondCategoryId { get; set; }

        /// <summary>
        /// 二级类目名称
        /// </summary>
        [JsonProperty("second_category_name")]
        [XmlElement("second_category_name")]
        public string SecondCategoryName { get; set; }
    }
}
