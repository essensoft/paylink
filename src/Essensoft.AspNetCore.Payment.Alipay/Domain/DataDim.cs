using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DataDim Data Structure.
    /// </summary>
    [Serializable]
    public class DataDim : AlipayObject
    {
        /// <summary>
        /// 维度名称，代表维度层级含义  不同维度间用“|”分割
        /// </summary>
        [JsonProperty("dim_name")]
        [XmlElement("dim_name")]
        public string DimName { get; set; }

        /// <summary>
        /// 维度类型，并级或者层级  parallel     并列维度  hierarchical 层级维度
        /// </summary>
        [JsonProperty("dim_type")]
        [XmlElement("dim_type")]
        public string DimType { get; set; }

        /// <summary>
        /// 维度值，代表维度层级的值
        /// </summary>
        [JsonProperty("dim_value")]
        [XmlElement("dim_value")]
        public string DimValue { get; set; }
    }
}
