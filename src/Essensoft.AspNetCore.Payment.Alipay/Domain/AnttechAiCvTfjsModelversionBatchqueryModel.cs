using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechAiCvTfjsModelversionBatchqueryModel Data Structure.
    /// </summary>
    public class AnttechAiCvTfjsModelversionBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// tfjs端模型code，多个code之间用英文逗号分隔
        /// </summary>
        [JsonPropertyName("model_code")]
        public string ModelCode { get; set; }
    }
}
