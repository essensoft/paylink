using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskAuthenticationQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskAuthenticationQueryModel : AlipayObject
    {
        /// <summary>
        /// 身份安全业务场景信息
        /// </summary>
        [JsonPropertyName("authentication_scene")]
        public AuthenticationScene AuthenticationScene { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务信息
        /// </summary>
        [JsonPropertyName("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 身份安全业务初始化后生成的token
        /// </summary>
        [JsonPropertyName("token_id")]
        public string TokenId { get; set; }
    }
}
