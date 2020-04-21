using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppMembersQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppMembersQueryModel : AlipayObject
    {
        /// <summary>
        /// 成员的角色类型，DEVELOPER-开发者，EXPERIENCER-体验者
        /// </summary>
        [JsonPropertyName("role")]
        public string Role { get; set; }
    }
}
