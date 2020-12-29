using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AgentVO Data Structure.
    /// </summary>
    public class AgentVO : AlipayObject
    {
        /// <summary>
        /// 热线接入方式
        /// </summary>
        [JsonPropertyName("answering_mode")]
        public string AnsweringMode { get; set; }

        /// <summary>
        /// 头像的oss file key
        /// </summary>
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 客服归属的部门id列表
        /// </summary>
        [JsonPropertyName("ccs_instance_ids")]
        public List<string> CcsInstanceIds { get; set; }

        /// <summary>
        /// 在线技能组信息
        /// </summary>
        [JsonPropertyName("chat_config")]
        public List<AgentChatInfo> ChatConfig { get; set; }

        /// <summary>
        /// 创建时间， 标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 钉钉user_id（绑定钉钉的用户该字段非空）
        /// </summary>
        [JsonPropertyName("dingtalk_user_id")]
        public string DingtalkUserId { get; set; }

        /// <summary>
        /// 客服邮箱
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 外部系统用户,比如金融云的用户id、支付宝账号id
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 热线技能组信息
        /// </summary>
        [JsonPropertyName("hotline_config")]
        public List<AgentHotlineInfo> HotlineConfig { get; set; }

        /// <summary>
        /// 客服唯一标识id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 客服工号
        /// </summary>
        [JsonPropertyName("job_number")]
        public string JobNumber { get; set; }

        /// <summary>
        /// 最后登录时间,标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("last_login_time")]
        public string LastLoginTime { get; set; }

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
        /// 个人简介
        /// </summary>
        [JsonPropertyName("profile")]
        public string Profile { get; set; }

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
        /// 状态：NORMAL，DELETE
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户类型：NORMAL（普通客服），ADMIN（超级管理员，不能被删除）
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 最后修改时间， 标准时间格式：yyyy-MM-dd HH:mm:ss
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
