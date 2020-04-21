using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskAuthenticationCancelModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskAuthenticationCancelModel : AlipayObject
    {
        /// <summary>
        /// 身份认证场景信息
        /// </summary>
        [JsonPropertyName("authentication_scene")]
        public AuthenticationScene AuthenticationScene { get; set; }

        /// <summary>
        /// 业务流水号，与初始化接口保持一致
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务参数
        /// </summary>
        [JsonPropertyName("biz_info")]
        public string BizInfo { get; set; }

        /// <summary>
        /// 身份认证初始化返回token_id
        /// </summary>
        [JsonPropertyName("token_id")]
        public string TokenId { get; set; }
    }
}
