using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserPermit Data Structure.
    /// </summary>
    public class UserPermit : AlipayObject
    {
        /// <summary>
        /// 用户授权接收消息状态
        /// </summary>
        [JsonPropertyName("permit_status")]
        public string PermitStatus { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
