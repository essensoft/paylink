using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PortraitDistribution Data Structure.
    /// </summary>
    public class PortraitDistribution : AlipayObject
    {
        /// <summary>
        /// 分布段的key
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 该分布段的数量
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// 该分布段的比例
        /// </summary>
        [JsonPropertyName("ratio")]
        public string Ratio { get; set; }
    }
}
