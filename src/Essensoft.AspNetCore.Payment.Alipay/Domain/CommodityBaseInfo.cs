using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CommodityBaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CommodityBaseInfo : AlipayObject
    {
        /// <summary>
        /// 服务logo
        /// </summary>
        [JsonProperty("logo")]
        [XmlElement("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 服务备注
        /// </summary>
        [JsonProperty("memo")]
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务地址
        /// </summary>
        [JsonProperty("service_url")]
        [XmlElement("service_url")]
        public string ServiceUrl { get; set; }
    }
}
