using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceCreateModel Data Structure.
    /// </summary>
    public class AlipayBossBaseProcessInstanceCreateModel : AlipayObject
    {
        /// <summary>
        /// 加签内容
        /// </summary>
        [JsonPropertyName("add_sign_content")]
        public List<BPOpenApiAddSignContent> AddSignContent { get; set; }

        /// <summary>
        /// 业务上下文，JSON格式
        /// </summary>
        [JsonPropertyName("context")]
        public string Context { get; set; }

        /// <summary>
        /// 创建人的域账号
        /// </summary>
        [JsonPropertyName("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 2088账号
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 流程配置名称。需要先在流程平台配置流程
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 优先级，数字越大优先级越高，最大不超过29
        /// </summary>
        [JsonPropertyName("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 流程全局唯一ID，和业务一一对应
        /// </summary>
        [JsonPropertyName("puid")]
        public BPOpenApiPUID Puid { get; set; }

        /// <summary>
        /// 前置流程从哪个节点发起的本流程
        /// </summary>
        [JsonPropertyName("source_node_name")]
        public string SourceNodeName { get; set; }

        /// <summary>
        /// 前置流程的PUID。用于串连起两个流程
        /// </summary>
        [JsonPropertyName("source_puid")]
        public string SourcePuid { get; set; }

        /// <summary>
        /// 子流程的上下文。每一个上下文都使用JSON格式
        /// </summary>
        [JsonPropertyName("sub_contexts")]
        public List<string> SubContexts { get; set; }
    }
}
