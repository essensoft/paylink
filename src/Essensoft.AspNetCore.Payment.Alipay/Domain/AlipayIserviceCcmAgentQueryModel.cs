using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmAgentQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmAgentQueryModel : AlipayObject
    {
        /// <summary>
        /// 热线接入方式
        /// </summary>
        [JsonPropertyName("answering_mode")]
        public string AnsweringMode { get; set; }

        /// <summary>
        /// 部门id
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 在线扩展技能组id
        /// </summary>
        [JsonPropertyName("chat_ext_group_ids")]
        public List<string> ChatExtGroupIds { get; set; }

        /// <summary>
        /// 在线技能组id
        /// </summary>
        [JsonPropertyName("chat_group_ids")]
        public List<string> ChatGroupIds { get; set; }

        /// <summary>
        /// 在线服务等级
        /// </summary>
        [JsonPropertyName("chat_level_ids")]
        public List<string> ChatLevelIds { get; set; }

        /// <summary>
        /// 客服邮箱
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 热线扩展技能组id
        /// </summary>
        [JsonPropertyName("hotline_group_ids")]
        public List<string> HotlineGroupIds { get; set; }

        /// <summary>
        /// 查询结果的页码，起始值为 1，默认值为 1
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询时设置的每页记录数，最大值 100 行，默认为 10
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 客服姓名
        /// </summary>
        [JsonPropertyName("real_name")]
        public string RealName { get; set; }

        /// <summary>
        /// 客服角色id
        /// </summary>
        [JsonPropertyName("role_ids")]
        public List<string> RoleIds { get; set; }
    }
}
