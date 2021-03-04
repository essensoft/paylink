using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AnttechAiCvTfjsModelversionBatchqueryResponse.
    /// </summary>
    public class AnttechAiCvTfjsModelversionBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// jsonString，不涉及商户敏感信息
        /// </summary>
        [JsonPropertyName("model_version")]
        public string ModelVersion { get; set; }
    }
}
