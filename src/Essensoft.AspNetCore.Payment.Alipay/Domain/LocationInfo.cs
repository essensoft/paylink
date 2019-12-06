using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LocationInfo Data Structure.
    /// </summary>
    public class LocationInfo : AlipayObject
    {
        /// <summary>
        /// 用户所处的经度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 用户当前的纬度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 国家统一行政编码
        /// </summary>
        [JsonPropertyName("region_code")]
        public string RegionCode { get; set; }
    }
}
