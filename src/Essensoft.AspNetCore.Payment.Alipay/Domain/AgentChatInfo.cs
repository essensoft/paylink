using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AgentChatInfo Data Structure.
    /// </summary>
    public class AgentChatInfo : AlipayObject
    {
        /// <summary>
        /// 数据权限id(租户实例id)
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 在线扩展技能组id列表
        /// </summary>
        [JsonPropertyName("extended_group_ids")]
        public List<string> ExtendedGroupIds { get; set; }

        /// <summary>
        /// 在线技能组id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 在线服务等级
        /// </summary>
        [JsonPropertyName("level_id")]
        public string LevelId { get; set; }
    }
}
