using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RegionInfo Data Structure.
    /// </summary>
    public class RegionInfo : AlipayObject
    {
        /// <summary>
        /// 地址所属区代码
        /// </summary>
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 地址所属区名称
        /// </summary>
        [JsonPropertyName("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 地址所属市代码
        /// </summary>
        [JsonPropertyName("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 地址所属市名称
        /// </summary>
        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 地址所属省份代码
        /// </summary>
        [JsonPropertyName("province_code")]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 地址所属省份名称
        /// </summary>
        [JsonPropertyName("province_name")]
        public string ProvinceName { get; set; }
    }
}
