using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AuthenticationInfo Data Structure.
    /// </summary>
    public class AuthenticationInfo : AlipayObject
    {
        /// <summary>
        /// 身份认证场景信息
        /// </summary>
        [JsonPropertyName("authentication_scene")]
        public AuthenticationScene AuthenticationScene { get; set; }

        /// <summary>
        /// 标识一笔业务，业务方生成
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务扩展信息
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 身份认证业务用户主体信息
        /// </summary>
        [JsonPropertyName("principal_info")]
        public PrincipalInfo PrincipalInfo { get; set; }
    }
}
