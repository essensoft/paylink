using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntProdpaasProductCommonQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntProdpaasProductCommonQueryModel : AlipayObject
    {
        /// <summary>
        /// 产品码
        /// </summary>
        [JsonProperty("product_code")]
        [XmlElement("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 产品查询维度，主要分为基础信息，条件信息和产品关联关系信息等
        /// </summary>
        [JsonProperty("product_options")]
        [XmlElement("product_options")]
        public ProductVOOptions ProductOptions { get; set; }

        /// <summary>
        /// 产品版本
        /// </summary>
        [JsonProperty("product_version")]
        [XmlElement("product_version")]
        public string ProductVersion { get; set; }
    }
}
