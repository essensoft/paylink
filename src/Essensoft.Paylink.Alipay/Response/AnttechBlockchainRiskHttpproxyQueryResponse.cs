using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainRiskHttpproxyQueryResponse.
    /// </summary>
    public class AnttechBlockchainRiskHttpproxyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 返回接口数据，例如mps模型，只有标签和评分，无个人敏感信息
        /// </summary>
        [JsonPropertyName("response")]
        public string Response { get; set; }

        /// <summary>
        /// 响应成功与否
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 业务唯一识别码traceId
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }
    }
}
