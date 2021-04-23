using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// Hylabel Data Structure.
    /// </summary>
    public class Hylabel : AlipayObject
    {
        /// <summary>
        /// 行业id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 行业标签名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 概率值
        /// </summary>
        [JsonPropertyName("probabilities")]
        public string Probabilities { get; set; }
    }
}
