using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMapGeocodingReverseResponse.
    /// </summary>
    public class AlipayEcoMapGeocodingReverseResponse : AlipayResponse
    {
        /// <summary>
        /// 城市名称
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 区名称
        /// </summary>
        [JsonPropertyName("district")]
        public string District { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }
    }
}
