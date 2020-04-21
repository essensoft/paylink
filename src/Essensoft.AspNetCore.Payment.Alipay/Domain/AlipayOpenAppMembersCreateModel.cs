using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppMembersCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenAppMembersCreateModel : AlipayObject
    {
        /// <summary>
        /// 支付宝登录账号ID
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 成员的角色类型，DEVELOPER-开发者，EXPERIENCER-体验者
        /// </summary>
        [JsonPropertyName("role")]
        public string Role { get; set; }
    }
}
