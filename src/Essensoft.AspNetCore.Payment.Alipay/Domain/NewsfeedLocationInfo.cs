using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NewsfeedLocationInfo Data Structure.
    /// </summary>
    [Serializable]
    public class NewsfeedLocationInfo : AlipayObject
    {
        /// <summary>
        /// 地理信息
        /// </summary>
        [JsonProperty("ad_code")]
        [XmlElement("ad_code")]
        public string AdCode { get; set; }

        /// <summary>
        /// 纬度 latitude（填写非0非1）
        /// </summary>
        [JsonProperty("lat")]
        [XmlElement("lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度 longitude（填写非0非1）
        /// </summary>
        [JsonProperty("lon")]
        [XmlElement("lon")]
        public string Lon { get; set; }
    }
}
