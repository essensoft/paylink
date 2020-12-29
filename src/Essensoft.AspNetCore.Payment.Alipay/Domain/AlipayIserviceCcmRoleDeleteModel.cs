using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmRoleDeleteModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmRoleDeleteModel : AlipayObject
    {
        /// <summary>
        /// 部门id（即租户实例ID、数据权限ID），如果不传入，使用租户id
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
