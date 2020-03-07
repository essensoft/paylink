using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// POIinfo Data Structure.
    /// </summary>
    public class POIinfo : AlipayObject
    {
        /// <summary>
        /// poi地址信息
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// POI所在商圈名称
        /// </summary>
        [JsonPropertyName("businessarea")]
        public string Businessarea { get; set; }

        /// <summary>
        /// 输入点相对POI的方位
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 该POI到请求坐标的距离
        /// </summary>
        [JsonPropertyName("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// POI的id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// POI中心点的坐标
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// POI名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [JsonPropertyName("tel")]
        public string Tel { get; set; }

        /// <summary>
        /// POI的类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
