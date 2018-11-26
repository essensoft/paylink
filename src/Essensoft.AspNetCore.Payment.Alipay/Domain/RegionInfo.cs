using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RegionInfo Data Structure.
    /// </summary>
    [Serializable]
    public class RegionInfo : AlipayObject
    {
        /// <summary>
        /// 地址所属区代码
        /// </summary>
        [JsonProperty("area_code")]
        [XmlElement("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 地址所属区名称
        /// </summary>
        [JsonProperty("area_name")]
        [XmlElement("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 地址所属市代码
        /// </summary>
        [JsonProperty("city_code")]
        [XmlElement("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 地址所属市名称
        /// </summary>
        [JsonProperty("city_name")]
        [XmlElement("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 地址所属省份代码
        /// </summary>
        [JsonProperty("province_code")]
        [XmlElement("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 地址所属省份名称
        /// </summary>
        [JsonProperty("province_name")]
        [XmlElement("province_name")]
        public string ProvinceName { get; set; }
    }
}
