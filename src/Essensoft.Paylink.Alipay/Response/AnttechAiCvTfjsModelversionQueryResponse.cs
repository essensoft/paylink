using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AnttechAiCvTfjsModelversionQueryResponse.
    /// </summary>
    public class AnttechAiCvTfjsModelversionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 对应模型最新版本号
        /// </summary>
        [JsonPropertyName("model_version")]
        public string ModelVersion { get; set; }
    }
}
