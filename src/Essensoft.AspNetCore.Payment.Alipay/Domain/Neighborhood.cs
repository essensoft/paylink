using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Neighborhood Data Structure.
    /// </summary>
    public class Neighborhood : AlipayObject
    {
        /// <summary>
        /// 社区名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// POI类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
