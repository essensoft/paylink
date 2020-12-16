using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Role Data Structure.
    /// </summary>
    public class Role : AlipayObject
    {
        /// <summary>
        /// 部门id（即租户实例ID、数据权限ID）
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 角色描述描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 角色关联额功能点id
        /// </summary>
        [JsonPropertyName("function_ids")]
        public List<string> FunctionIds { get; set; }

        /// <summary>
        /// 角色id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 角色名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        [JsonPropertyName("update_time")]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 最后修改人id
        /// </summary>
        [JsonPropertyName("updater_id")]
        public string UpdaterId { get; set; }
    }
}
