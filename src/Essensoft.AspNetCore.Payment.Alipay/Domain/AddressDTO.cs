using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AddressDTO Data Structure.
    /// </summary>
    public class AddressDTO : AlipayObject
    {
        /// <summary>
        /// POI编码
        /// </summary>
        [JsonPropertyName("poi_code")]
        public string PoiCode { get; set; }

        /// <summary>
        /// POI访问URL
        /// </summary>
        [JsonPropertyName("poi_url")]
        public string PoiUrl { get; set; }
    }
}
