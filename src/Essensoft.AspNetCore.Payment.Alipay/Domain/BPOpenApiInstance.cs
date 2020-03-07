using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BPOpenApiInstance Data Structure.
    /// </summary>
    public class BPOpenApiInstance : AlipayObject
    {
        /// <summary>
        /// 业务上下文，JSON格式
        /// </summary>
        [JsonPropertyName("biz_context")]
        public string BizContext { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 创建人域账号
        /// </summary>
        [JsonPropertyName("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 流程实例描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 创建到完成的毫秒数，未完结为0
        /// </summary>
        [JsonPropertyName("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 完结时间,未完结时为空
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 2088账号
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 最后更新人域账号
        /// </summary>
        [JsonPropertyName("modify_user")]
        public string ModifyUser { get; set; }

        /// <summary>
        /// 流程配置名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 父流程实例ID。用于描述父子流程
        /// </summary>
        [JsonPropertyName("parent_id")]
        public string ParentId { get; set; }

        /// <summary>
        /// 父流程实例所处的节点
        /// </summary>
        [JsonPropertyName("parent_node")]
        public string ParentNode { get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [JsonPropertyName("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 全局唯一ID
        /// </summary>
        [JsonPropertyName("puid")]
        public string Puid { get; set; }

        /// <summary>
        /// 前置流程ID。用于描述流程串联
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; }

        /// <summary>
        /// 前置流程从哪个节点发起的本流程
        /// </summary>
        [JsonPropertyName("source_node_name")]
        public string SourceNodeName { get; set; }

        /// <summary>
        /// 流程实例状态:CREATED,PROCESSING,COMPLETED,CANCELED
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// 包含的任务列表
        /// </summary>
        [JsonPropertyName("tasks")]
        public List<BPOpenApiTask> Tasks { get; set; }
    }
}
