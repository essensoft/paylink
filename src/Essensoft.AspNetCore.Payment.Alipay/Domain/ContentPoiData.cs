using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContentPoiData Data Structure.
    /// </summary>
    public class ContentPoiData : AlipayObject
    {
        /// <summary>
        /// poi纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// poi经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 位置信息
        /// </summary>
        [JsonPropertyName("poi_name")]
        public string PoiName { get; set; }
    }
}
