using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AgentHotlineInfo Data Structure.
    /// </summary>
    public class AgentHotlineInfo : AlipayObject
    {
        /// <summary>
        /// 数据权限id(租户实例id)
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 热线技能组id
        /// </summary>
        [JsonPropertyName("group_ids")]
        public List<string> GroupIds { get; set; }
    }
}
