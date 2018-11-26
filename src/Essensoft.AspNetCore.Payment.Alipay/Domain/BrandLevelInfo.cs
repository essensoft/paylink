using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BrandLevelInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BrandLevelInfo : AlipayObject
    {
        /// <summary>
        /// 品牌编码
        /// </summary>
        [JsonProperty("brand_code")]
        [XmlElement("brand_code")]
        public string BrandCode { get; set; }

        /// <summary>
        /// 当前品牌所属级别
        /// </summary>
        [JsonProperty("brand_level")]
        [XmlElement("brand_level")]
        public long BrandLevel { get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonProperty("brand_name")]
        [XmlElement("brand_name")]
        public string BrandName { get; set; }
    }
}
