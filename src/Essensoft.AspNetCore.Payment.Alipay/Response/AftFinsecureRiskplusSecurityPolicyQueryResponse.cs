using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AftFinsecureRiskplusSecurityPolicyQueryResponse.
    /// </summary>
    public class AftFinsecureRiskplusSecurityPolicyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 风险咨询情况下返回的风险等级，风险处理不会返回该值
        /// </summary>
        [JsonPropertyName("level")]
        public long Level { get; set; }

        /// <summary>
        /// 反馈成功之后的id
        /// </summary>
        [JsonPropertyName("security_id")]
        public string SecurityId { get; set; }

        /// <summary>
        /// 安全处理结果，枚举值为：reject[拒绝],validate[校验],accept[放过]
        /// </summary>
        [JsonPropertyName("security_result")]
        public string SecurityResult { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }

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
