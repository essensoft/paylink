using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// StationDetailInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StationDetailInfo : AlipayObject
    {
        /// <summary>
        /// 站点编码
        /// </summary>
        [JsonProperty("code")]
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 站点外部编码
        /// </summary>
        [JsonProperty("ext_code")]
        [XmlElement("ext_code")]
        public string ExtCode { get; set; }

        /// <summary>
        /// 站点中文名称
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }
    }
}
