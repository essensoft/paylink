using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommercePoiPowerbanklocationQueryModel Data Structure.
    /// </summary>
    public class AlipayCommercePoiPowerbanklocationQueryModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext")]
        public string Ext { get; set; }

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

        /// <summary>
        /// 半径范围
        /// </summary>
        [JsonPropertyName("radius_range")]
        public string RadiusRange { get; set; }
    }
}
