using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BusinessPermission Data Structure.
    /// </summary>
    public class BusinessPermission : AlipayObject
    {
        /// <summary>
        /// 业务隔离字段
        /// </summary>
        [JsonPropertyName("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 权限码名称
        /// </summary>
        [JsonPropertyName("permission_code")]
        public string PermissionCode { get; set; }

        /// <summary>
        /// 权限码值
        /// </summary>
        [JsonPropertyName("source_permission_code")]
        public string SourcePermissionCode { get; set; }
    }
}
