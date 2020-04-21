using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IndexDetail Data Structure.
    /// </summary>
    public class IndexDetail : AlipayObject
    {
        /// <summary>
        /// 区域编码
        /// </summary>
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 区域名称
        /// </summary>
        [JsonPropertyName("area_name")]
        public string AreaName { get; set; }

        /// <summary>
        /// 当月市排名
        /// </summary>
        [JsonPropertyName("city_ranking")]
        public string CityRanking { get; set; }

        /// <summary>
        /// 当月区排名
        /// </summary>
        [JsonPropertyName("county_ranking")]
        public string CountyRanking { get; set; }

        /// <summary>
        /// 主键
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 指数值
        /// </summary>
        [JsonPropertyName("index_val")]
        public string IndexVal { get; set; }

        /// <summary>
        /// 年月
        /// </summary>
        [JsonPropertyName("period")]
        public string Period { get; set; }
    }
}
