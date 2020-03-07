using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserConfirmPayload Data Structure.
    /// </summary>
    public class UserConfirmPayload : AlipayObject
    {
        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 用户校验token
        /// </summary>
        [JsonPropertyName("user_token")]
        public string UserToken { get; set; }
    }
}
