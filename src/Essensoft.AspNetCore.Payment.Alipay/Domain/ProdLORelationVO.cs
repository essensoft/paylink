using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProdLORelationVO Data Structure.
    /// </summary>
    [Serializable]
    public class ProdLORelationVO : AlipayObject
    {
        /// <summary>
        /// 区域编码
        /// </summary>
        [JsonProperty("lo_code")]
        [XmlElement("lo_code")]
        public string LoCode { get; set; }

        /// <summary>
        /// 区域类型
        /// </summary>
        [JsonProperty("lo_type")]
        [XmlElement("lo_type")]
        public string LoType { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonProperty("prod_code")]
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 产品版本
        /// </summary>
        [JsonProperty("prod_version")]
        [XmlElement("prod_version")]
        public string ProdVersion { get; set; }
    }
}
