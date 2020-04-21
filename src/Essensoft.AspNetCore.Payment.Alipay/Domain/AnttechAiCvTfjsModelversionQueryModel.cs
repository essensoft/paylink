using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechAiCvTfjsModelversionQueryModel Data Structure.
    /// </summary>
    public class AnttechAiCvTfjsModelversionQueryModel : AlipayObject
    {
        /// <summary>
        /// tfjs端模型code
        /// </summary>
        [JsonPropertyName("model_code")]
        public string ModelCode { get; set; }
    }
}
