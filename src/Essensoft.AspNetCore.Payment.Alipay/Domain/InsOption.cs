using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsOption Data Structure.
    /// </summary>
    public class InsOption : AlipayObject
    {
        /// <summary>
        /// 保额key
        /// </summary>
        [JsonPropertyName("coverage")]
        public string Coverage { get; set; }

        /// <summary>
        /// 保额value
        /// </summary>
        [JsonPropertyName("coverage_text")]
        public string CoverageText { get; set; }
    }
}
