using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppMembersQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppMembersQueryModel : AlipayObject
    {
        /// <summary>
        /// 查询的成员角色类型，枚举支持： DEVELOPER：开发者。 EXPERIENCER：体验者
        /// </summary>
        [JsonPropertyName("role")]
        public string Role { get; set; }
    }
}
