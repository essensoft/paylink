using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotDeviceAddressQueryResponse.
    /// </summary>
    public class AlipayCommerceIotDeviceAddressQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 城市名称
        /// </summary>
        [JsonPropertyName("city_name")]
        public string CityName { get; set; }

        /// <summary>
        /// 国家信息
        /// </summary>
        [JsonPropertyName("country_name")]
        public string CountryName { get; set; }

        /// <summary>
        /// 县/区名称
        /// </summary>
        [JsonPropertyName("county_name")]
        public string CountyName { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [JsonPropertyName("province_name")]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 街道名称
        /// </summary>
        [JsonPropertyName("town_name")]
        public string TownName { get; set; }
    }
}
