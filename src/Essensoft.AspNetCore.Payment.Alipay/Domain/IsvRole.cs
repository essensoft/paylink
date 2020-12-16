using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IsvRole Data Structure.
    /// </summary>
    public class IsvRole : AlipayObject
    {
        /// <summary>
        /// isv定义的角色的唯一标识
        /// </summary>
        [JsonPropertyName("role_id")]
        public string RoleId { get; set; }

        /// <summary>
        /// isv定义的角色名称
        /// </summary>
        [JsonPropertyName("role_name")]
        public string RoleName { get; set; }
    }
}
