using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Businessarea Data Structure.
    /// </summary>
    public class Businessarea : AlipayObject
    {
        /// <summary>
        /// 商圈所在区域的adcode
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商圈中心点经纬度
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// 商圈名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
