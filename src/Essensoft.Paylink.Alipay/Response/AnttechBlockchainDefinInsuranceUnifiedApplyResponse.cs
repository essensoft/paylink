using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AnttechBlockchainDefinInsuranceUnifiedApplyResponse.
    /// </summary>
    public class AnttechBlockchainDefinInsuranceUnifiedApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 业务消息
        /// </summary>
        [JsonPropertyName("biz_message")]
        public string BizMessage { get; set; }

        /// <summary>
        /// 保司投保单号
        /// </summary>
        [JsonPropertyName("inst_apply_no")]
        public string InstApplyNo { get; set; }

        /// <summary>
        /// 保司保单号
        /// </summary>
        [JsonPropertyName("inst_policy_no")]
        public string InstPolicyNo { get; set; }

        /// <summary>
        /// 保单状态
        /// </summary>
        [JsonPropertyName("policy_status")]
        public string PolicyStatus { get; set; }

        /// <summary>
        /// 原币种保费
        /// </summary>
        [JsonPropertyName("premium")]
        public string Premium { get; set; }

        /// <summary>
        /// 请求交易流水号
        /// </summary>
        [JsonPropertyName("request_no")]
        public string RequestNo { get; set; }
    }
}
