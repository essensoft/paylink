using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppMembersDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenAppMembersDeleteModel : AlipayObject
    {
        /// <summary>
        /// 被删除成员的角色类型，枚举支持： DEVELOPER：开发者。 EXPERIENCER：体验者。
        /// </summary>
        [JsonPropertyName("role")]
        public string Role { get; set; }

        /// <summary>
        /// 被删除成员的支付宝账户唯一标识，以2088开头。
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
