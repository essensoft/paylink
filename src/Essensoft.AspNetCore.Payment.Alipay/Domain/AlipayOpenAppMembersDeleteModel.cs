using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppMembersDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenAppMembersDeleteModel : AlipayObject
    {
        /// <summary>
        /// 成员的角色类型，DEVELOPER-开发者，EXPERIENCER-体验者
        /// </summary>
        [JsonPropertyName("role")]
        public string Role { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
