using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppMessageSubscriptionQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppMessageSubscriptionQueryModel : AlipayObject
    {
        /// <summary>
        /// 授权令牌
        /// </summary>
        [JsonPropertyName("auth_token")]
        public string AuthToken { get; set; }

        /// <summary>
        /// 授权类型。支持： app_auth：三方应用授权。 user_auth：用户授权。 例如app_auth表示三方应用授权
        /// </summary>
        [JsonPropertyName("auth_type")]
        public string AuthType { get; set; }

        /// <summary>
        /// 消息标签，用于消息子类型过滤。使用前请确认消息topic是否支持。若topic传入的消息接口中未定义 tag 则不支持传递。
        /// </summary>
        [JsonPropertyName("tag")]
        public string Tag { get; set; }

        /// <summary>
        /// 消息主题名称，即消息接口英文名。
        /// </summary>
        [JsonPropertyName("topic")]
        public string Topic { get; set; }
    }
}
