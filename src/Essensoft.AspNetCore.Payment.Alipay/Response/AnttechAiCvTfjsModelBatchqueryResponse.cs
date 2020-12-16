using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechAiCvTfjsModelBatchqueryResponse.
    /// </summary>
    public class AnttechAiCvTfjsModelBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// jsonString内容，不涉及商户敏感信息
        /// </summary>
        [JsonPropertyName("model_info")]
        public string ModelInfo { get; set; }
    }
}
