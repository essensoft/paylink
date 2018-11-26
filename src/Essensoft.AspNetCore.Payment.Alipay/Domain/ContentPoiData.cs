using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContentPoiData Data Structure.
    /// </summary>
    [Serializable]
    public class ContentPoiData : AlipayObject
    {
        /// <summary>
        /// poi纬度
        /// </summary>
        [JsonProperty("latitude")]
        [XmlElement("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// poi经度
        /// </summary>
        [JsonProperty("longitude")]
        [XmlElement("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 位置信息
        /// </summary>
        [JsonProperty("poi_name")]
        [XmlElement("poi_name")]
        public string PoiName { get; set; }
    }
}
