using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RoleId Data Structure.
    /// </summary>
    public class RoleId : AlipayObject
    {
        /// <summary>
        /// 部门id（即租户实例ID、数据权限ID）
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 角色ID
        /// </summary>
        [JsonPropertyName("role_id")]
        public string RoleId_ { get; set; }
    }
}
