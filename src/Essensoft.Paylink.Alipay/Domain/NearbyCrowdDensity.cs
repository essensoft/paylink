using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// NearbyCrowdDensity Data Structure.
    /// </summary>
    public class NearbyCrowdDensity : AlipayObject
    {
        /// <summary>
        /// 人群密度，示例值：高、中、低
        /// </summary>
        [JsonPropertyName("crowd_density")]
        public string CrowdDensity { get; set; }

        /// <summary>
        /// 网格计算模型
        /// </summary>
        [JsonPropertyName("geohash")]
        public string Geohash { get; set; }
    }
}
