using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ServiceAddressSimpleVO Data Structure.
    /// </summary>
    public class ServiceAddressSimpleVO : AlipayObject
    {
        /// <summary>
        /// 维度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// poi详细地址
        /// </summary>
        [JsonPropertyName("poi_address")]
        public string PoiAddress { get; set; }

        /// <summary>
        /// 高德的poi code
        /// </summary>
        [JsonPropertyName("poi_code")]
        public string PoiCode { get; set; }

        /// <summary>
        /// poi的名称
        /// </summary>
        [JsonPropertyName("poi_name")]
        public string PoiName { get; set; }
    }
}
