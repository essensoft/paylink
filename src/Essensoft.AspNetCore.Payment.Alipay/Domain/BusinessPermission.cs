using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BusinessPermission Data Structure.
    /// </summary>
    [Serializable]
    public class BusinessPermission : AlipayObject
    {
        /// <summary>
        /// 业务隔离字段
        /// </summary>
        [JsonProperty("domain")]
        public string Domain { get; set; }

        /// <summary>
        /// 权限码名称
        /// </summary>
        [JsonProperty("permission_code")]
        public string PermissionCode { get; set; }

        /// <summary>
        /// 权限码值
        /// </summary>
        [JsonProperty("source_permission_code")]
        public string SourcePermissionCode { get; set; }
    }
}
