using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmAgentGetResponse.
    /// </summary>
    public class AlipayIserviceCcmAgentGetResponse : AlipayResponse
    {
        /// <summary>
        /// 热线接入方式： 0：话机 1：电脑耳机；2：webrtc
        /// </summary>
        [JsonPropertyName("answering_mode")]
        public string AnsweringMode { get; set; }

        /// <summary>
        /// 头像的oss file key
        /// </summary>
        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }

        /// <summary>
        /// 客服关联的数据权限id列表
        /// </summary>
        [JsonPropertyName("ccs_instance_ids")]
        public List<string> CcsInstanceIds { get; set; }

        /// <summary>
        /// 客服在线信息
        /// </summary>
        [JsonPropertyName("chat_config")]
        public List<AgentChatInfo> ChatConfig { get; set; }

        /// <summary>
        /// 创建时间，采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd'T'HH:mm:ss'Z
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人id
        /// </summary>
        [JsonPropertyName("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 钉钉user_id
        /// </summary>
        [JsonPropertyName("dingtalk_user_id")]
        public string DingtalkUserId { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        /// 外部系统用户id,比如：金融云的用户id
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 客服热线信息
        /// </summary>
        [JsonPropertyName("hotline_config")]
        public List<AgentHotlineInfo> HotlineConfig { get; set; }

        /// <summary>
        /// 客服id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [JsonPropertyName("job_number")]
        public string JobNumber { get; set; }

        /// <summary>
        /// 客服上次登录时间 采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd'T'HH:mm:ss'Z'
        /// </summary>
        [JsonPropertyName("last_login_time")]
        public string LastLoginTime { get; set; }

        /// <summary>
        /// 手机号
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
        /// 角色id列表
        /// </summary>
        [JsonPropertyName("role_ids")]
        public List<RoleId> RoleIds { get; set; }

        /// <summary>
        /// 客服状态：NORMAL，DELETE
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户类型：NORMAL（普通客服），ADMIN（超级管理员，不能被删除）
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 最后修改时间，采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd'T'HH:mm:ss'Z'
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
