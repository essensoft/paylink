using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoMapGeocodingReverseModel Data Structure.
    /// </summary>
    public class AlipayEcoMapGeocodingReverseModel : AlipayObject
    {
        /// <summary>
        /// 渠道 0-高德地图 1-百度地图
        /// </summary>
        [JsonPropertyName("channel")]
        public long Channel { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }
    }
}
