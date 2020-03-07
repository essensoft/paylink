using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityRiskAuthenticationInitializeResponse.
    /// </summary>
    public class AlipaySecurityRiskAuthenticationInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 身份安全业务初始化后返回的业务信息
        /// </summary>
        [JsonPropertyName("biz_result")]
        public string BizResult { get; set; }

        /// <summary>
        /// 身份安全业务初始化后生成的token
        /// </summary>
        [JsonPropertyName("token_id")]
        public string TokenId { get; set; }
    }
}
