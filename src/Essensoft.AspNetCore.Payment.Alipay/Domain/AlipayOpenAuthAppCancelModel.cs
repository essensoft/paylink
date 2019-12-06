using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthAppCancelModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthAppCancelModel : AlipayObject
    {
        /// <summary>
        /// 授权方应用ID
        /// </summary>
        [JsonPropertyName("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 授权场景，固定值PLATFORM_APP_AUTH
        /// </summary>
        [JsonPropertyName("auth_scene")]
        public string AuthScene { get; set; }

        /// <summary>
        /// 当前登录账号支付宝userId
        /// </summary>
        [JsonPropertyName("operator_user_id")]
        public string OperatorUserId { get; set; }
    }
}
