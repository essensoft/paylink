using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PlantPlace Data Structure.
    /// </summary>
    public class PlantPlace : AlipayObject
    {
        /// <summary>
        /// 林区面积，单位：亩
        /// </summary>
        [JsonPropertyName("acreage")]
        public string Acreage { get; set; }

        /// <summary>
        /// 树已经种下时所在的林区id
        /// </summary>
        [JsonPropertyName("forest_id")]
        public string ForestId { get; set; }

        /// <summary>
        /// 林区名称
        /// </summary>
        [JsonPropertyName("forest_name")]
        public string ForestName { get; set; }

        /// <summary>
        /// 林区经纬度
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// 公益机构名称
        /// </summary>
        [JsonPropertyName("ngo_name")]
        public string NgoName { get; set; }

        /// <summary>
        /// 种植年份
        /// </summary>
        [JsonPropertyName("plant_time")]
        public string PlantTime { get; set; }

        /// <summary>
        /// 种植所在区域
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// 林区树木数量
        /// </summary>
        [JsonPropertyName("tree_count")]
        public long TreeCount { get; set; }
    }
}
