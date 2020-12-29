using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmRoleCreateModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmRoleCreateModel : AlipayObject
    {
        /// <summary>
        /// 部门id（即租户实例ID、数据权限ID）
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 角色描述信息
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 角色关联额功能点id
        /// </summary>
        [JsonPropertyName("function_ids")]
        public List<string> FunctionIds { get; set; }

        /// <summary>
        /// 角色名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
