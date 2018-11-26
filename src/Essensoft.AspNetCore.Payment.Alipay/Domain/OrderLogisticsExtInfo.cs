using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OrderLogisticsExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class OrderLogisticsExtInfo : AlipayObject
    {
        /// <summary>
        /// 服务结束时间，格式为yyyy-MM-dd HH:mm（到分）
        /// </summary>
        [JsonProperty("gmt_end")]
        [XmlElement("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 服务开始时间，格式为yyyy-MM-dd HH:mm（到分）
        /// </summary>
        [JsonProperty("gmt_start")]
        [XmlElement("gmt_start")]
        public string GmtStart { get; set; }
    }
}
