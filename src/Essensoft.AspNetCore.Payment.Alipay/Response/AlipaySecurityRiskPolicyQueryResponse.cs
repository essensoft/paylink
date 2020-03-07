using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskPolicyQueryResponse.
    /// </summary>
    public class AlipaySecurityRiskPolicyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否出二次核身的标识
        /// </summary>
        [JsonPropertyName("has_to_check")]
        public bool HasToCheck { get; set; }

        /// <summary>
        /// 风险咨询情况下返回的风险等级，风险处理不会返回该值
        /// </summary>
        [JsonPropertyName("level")]
        public long Level { get; set; }

        /// <summary>
        /// 查询是否成功
        /// </summary>
        [JsonPropertyName("query_success")]
        public bool QuerySuccess { get; set; }

        /// <summary>
        /// 安全请求生成的唯一ID
        /// </summary>
        [JsonPropertyName("security_id")]
        public string SecurityId { get; set; }

        /// <summary>
        /// 是否成功，本版本废弃
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 有风险需要失败业务情况下的返回码
        /// </summary>
        [JsonPropertyName("template_code")]
        public string TemplateCode { get; set; }

        /// <summary>
        /// 有风险需要失败业务情况下的返回码描述
        /// </summary>
        [JsonPropertyName("template_desc")]
        public string TemplateDesc { get; set; }

        /// <summary>
        /// native场景下的核身id
        /// </summary>
        [JsonPropertyName("verify_id")]
        public string VerifyId { get; set; }

        /// <summary>
        /// h5场景下的核身地址
        /// </summary>
        [JsonPropertyName("verify_url")]
        public string VerifyUrl { get; set; }
    }
}
