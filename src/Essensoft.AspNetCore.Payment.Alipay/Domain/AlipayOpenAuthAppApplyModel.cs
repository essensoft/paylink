using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAuthAppApplyModel Data Structure.
    /// </summary>
    public class AlipayOpenAuthAppApplyModel : AlipayObject
    {
        /// <summary>
        /// 授权方应用在蚂蚁开放平台的应用ID
        /// </summary>
        [JsonPropertyName("auth_app_id")]
        public string AuthAppId { get; set; }

        /// <summary>
        /// 授权场景，固定值PLATFORM_APP_AUTH
        /// </summary>
        [JsonPropertyName("auth_scene")]
        public string AuthScene { get; set; }

        /// <summary>
        /// 当前登录账号的支付宝userId
        /// </summary>
        [JsonPropertyName("operator_user_id")]
        public string OperatorUserId { get; set; }
    }
}
