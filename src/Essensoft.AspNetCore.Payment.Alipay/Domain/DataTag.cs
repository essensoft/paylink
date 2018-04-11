using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DataTag Data Structure.
    /// </summary>
    [Serializable]
    public class DataTag : AlipayObject
    {
        /// <summary>
        /// 聚合方式NONE,COUNT,COUNT_DISTINCT,DISTINCT,MIN,MAX,SUM
        /// </summary>
        [JsonProperty("aggregate")]
        [XmlElement("aggregate")]
        public string Aggregate { get; set; }

        /// <summary>
        /// 列别名
        /// </summary>
        [JsonProperty("alias")]
        [XmlElement("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 标签CODE
        /// </summary>
        [JsonProperty("code")]
        [XmlElement("code")]
        public string Code { get; set; }
    }
}
