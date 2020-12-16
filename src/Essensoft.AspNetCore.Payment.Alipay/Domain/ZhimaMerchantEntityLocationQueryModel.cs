using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantEntityLocationQueryModel Data Structure.
    /// </summary>
    public class ZhimaMerchantEntityLocationQueryModel : AlipayObject
    {
        /// <summary>
        /// 实体类目
        /// </summary>
        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

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
