using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SearchProductRegion Data Structure.
    /// </summary>
    public class SearchProductRegion : AlipayObject
    {
        /// <summary>
        /// 是否包含
        /// </summary>
        [JsonPropertyName("is_excluded")]
        public string IsExcluded { get; set; }

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
        /// 半径
        /// </summary>
        [JsonPropertyName("radius")]
        public string Radius { get; set; }

        /// <summary>
        /// 区域编码
        /// </summary>
        [JsonPropertyName("region_code")]
        public string RegionCode { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        [JsonPropertyName("region_name")]
        public string RegionName { get; set; }

        /// <summary>
        /// 区域类型（省、市、区县）
        /// </summary>
        [JsonPropertyName("region_type")]
        public string RegionType { get; set; }
    }
}
