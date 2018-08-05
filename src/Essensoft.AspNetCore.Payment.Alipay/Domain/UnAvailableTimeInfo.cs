using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UnAvailableTimeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class UnAvailableTimeInfo : AlipayObject
    {
        /// <summary>
        /// 起始时间
        /// </summary>
        [JsonProperty("from_date")]
        [XmlElement("from_date")]
        public string FromDate { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("to_date")]
        [XmlElement("to_date")]
        public string ToDate { get; set; }
    }
}
