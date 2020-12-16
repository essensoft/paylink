using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SiteItem Data Structure.
    /// </summary>
    public class SiteItem : AlipayObject
    {
        /// <summary>
        /// 经维度
        /// </summary>
        [JsonPropertyName("lat_1")]
        public string Lat1 { get; set; }

        /// <summary>
        /// 经维度
        /// </summary>
        [JsonPropertyName("lat_2")]
        public string Lat2 { get; set; }

        /// <summary>
        /// 经维度
        /// </summary>
        [JsonPropertyName("lat_3")]
        public string Lat3 { get; set; }

        /// <summary>
        /// 经维度
        /// </summary>
        [JsonPropertyName("lat_4")]
        public string Lat4 { get; set; }

        /// <summary>
        /// 经维度
        /// </summary>
        [JsonPropertyName("lon_1")]
        public string Lon1 { get; set; }

        /// <summary>
        /// 经维度
        /// </summary>
        [JsonPropertyName("lon_2")]
        public string Lon2 { get; set; }

        /// <summary>
        /// 经维度
        /// </summary>
        [JsonPropertyName("lon_3")]
        public string Lon3 { get; set; }

        /// <summary>
        /// 经维度
        /// </summary>
        [JsonPropertyName("lon_4")]
        public string Lon4 { get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 中心点经度
        /// </summary>
        [JsonPropertyName("s_lat")]
        public string SLat { get; set; }

        /// <summary>
        /// 中心点维度
        /// </summary>
        [JsonPropertyName("s_lon")]
        public string SLon { get; set; }

        /// <summary>
        /// 推荐打分
        /// </summary>
        [JsonPropertyName("score")]
        public long Score { get; set; }

        /// <summary>
        /// 站点id
        /// </summary>
        [JsonPropertyName("site_id")]
        public string SiteId { get; set; }
    }
}
