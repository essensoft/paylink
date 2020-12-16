using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExternalPoiInfo Data Structure.
    /// </summary>
    public class ExternalPoiInfo : AlipayObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 实例对应的ID
        /// </summary>
        [JsonPropertyName("entity_id")]
        public string EntityId { get; set; }

        /// <summary>
        /// 实体对应的类型
        /// </summary>
        [JsonPropertyName("entity_type")]
        public string EntityType { get; set; }

        /// <summary>
        /// 数据库主键
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

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
        /// 地理地址的备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 高德地图Point of Interest
        /// </summary>
        [JsonPropertyName("poi")]
        public string Poi { get; set; }
    }
}
