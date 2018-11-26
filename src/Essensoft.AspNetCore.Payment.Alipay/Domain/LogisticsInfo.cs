using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LogisticsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsInfo : AlipayObject
    {
        /// <summary>
        /// 物流公司code
        /// </summary>
        [JsonProperty("logistics_code")]
        [XmlElement("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonProperty("logistics_name")]
        [XmlElement("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonProperty("logistics_no")]
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }
    }
}
