using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmAgentModifyModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmAgentModifyModel : AlipayObject
    {
        /// <summary>
        /// 热线接入方式，取值0，1，2
        /// </summary>
        [JsonPropertyName("answering_mode")]
        public string AnsweringMode { get; set; }

        /// <summary>
        /// 部门id列表
        /// </summary>
        [JsonPropertyName("ccs_instance_ids")]
        public List<string> CcsInstanceIds { get; set; }

        /// <summary>
        /// 在线技能组设置，技能组部门间隔离，此设置应与ccs_instance_ids对应
        /// </summary>
        [JsonPropertyName("chat_configs")]
        public List<AgentChatInfo> ChatConfigs { get; set; }

        /// <summary>
        /// 客服邮箱
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 热线技能组设置，技能组部门间隔离，此设置应与ccs_instance_ids对应
        /// </summary>
        [JsonPropertyName("hotline_configs")]
        public List<AgentHotlineInfo> HotlineConfigs { get; set; }

        /// <summary>
        /// 客服id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 客服手机号
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 客服昵称
        /// </summary>
        [JsonPropertyName("nick_name")]
        public string NickName { get; set; }

        /// <summary>
        /// 客服姓名
        /// </summary>
        [JsonPropertyName("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 客服角色id列表
        /// </summary>
        [JsonPropertyName("role_ids")]
        public List<RoleId> RoleIds { get; set; }

        /// <summary>
        /// 操作人客服id
        /// </summary>
        [JsonPropertyName("updater_id")]
        public string UpdaterId { get; set; }
    }
}
