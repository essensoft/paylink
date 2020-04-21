using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// SsdataDataserviceRiskAudioQueryResponse.
    /// </summary>
    public class SsdataDataserviceRiskAudioQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 命中的用户自定义的关键词列表及选择的模型命中分数
        /// </summary>
        [JsonPropertyName("risk_result")]
        public string RiskResult { get; set; }

        /// <summary>
        /// 业务唯一识别码
        /// </summary>
        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; }
    }
}
