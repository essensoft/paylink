using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Road Data Structure.
    /// </summary>
    public class Road : AlipayObject
    {
        /// <summary>
        /// 输入点和此路的相对方位
        /// </summary>
        [JsonPropertyName("direction")]
        public string Direction { get; set; }

        /// <summary>
        /// 道路到请求坐标的距离
        /// </summary>
        [JsonPropertyName("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 道路ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 道路的中心点
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// 道路名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
