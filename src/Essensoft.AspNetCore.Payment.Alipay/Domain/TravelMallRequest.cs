using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TravelMallRequest Data Structure.
    /// </summary>
    [Serializable]
    public class TravelMallRequest : AlipayObject
    {
        /// <summary>
        /// 目的地距目标综合体的距离(单位:米)
        /// </summary>
        [JsonProperty("distance")]
        [XmlElement("distance")]
        public long Distance { get; set; }

        /// <summary>
        /// 综合体ID
        /// </summary>
        [JsonProperty("mall_id")]
        [XmlElement("mall_id")]
        public string MallId { get; set; }
    }
}
