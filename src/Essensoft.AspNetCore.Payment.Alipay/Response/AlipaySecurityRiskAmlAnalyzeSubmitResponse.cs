using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskAmlAnalyzeSubmitResponse.
    /// </summary>
    public class AlipaySecurityRiskAmlAnalyzeSubmitResponse : AlipayResponse
    {
        /// <summary>
        /// 反洗钱分析结果，ACCEPT：无风险；REJECT：有风险，拒绝；REVIEW：有疑似风险，由业务端决定是否放行
        /// </summary>
        [JsonPropertyName("aml_decision")]
        public string AmlDecision { get; set; }

        /// <summary>
        /// 反洗钱系统执行结果
        /// </summary>
        [JsonPropertyName("aml_result_code")]
        public string AmlResultCode { get; set; }

        /// <summary>
        /// 业务的唯一编码
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 请求的唯一编号，方便定位问题
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
