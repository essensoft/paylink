using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessInstanceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossBaseProcessInstanceCreateModel : AlipayObject
    {
        /// <summary>
        /// 加签内容
        /// </summary>
        [JsonProperty("add_sign_content")]
        [XmlArray("add_sign_content")]
        [XmlArrayItem("b_p_open_api_add_sign_content")]
        public List<BPOpenApiAddSignContent> AddSignContent { get; set; }

        /// <summary>
        /// 业务上下文，JSON格式
        /// </summary>
        [JsonProperty("context")]
        [XmlElement("context")]
        public string Context { get; set; }

        /// <summary>
        /// 创建人的域账号
        /// </summary>
        [JsonProperty("creator")]
        [XmlElement("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("description")]
        [XmlElement("description")]
        public string Description { get; set; }

        /// <summary>
        /// 2088账号
        /// </summary>
        [JsonProperty("ip_role_id")]
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 流程配置名称。需要先在流程平台配置流程
        /// </summary>
        [JsonProperty("name")]
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 优先级，数字越大优先级越高，最大不超过29
        /// </summary>
        [JsonProperty("priority")]
        [XmlElement("priority")]
        public long Priority { get; set; }

        /// <summary>
        /// 流程全局唯一ID，和业务一一对应
        /// </summary>
        [JsonProperty("puid")]
        [XmlElement("puid")]
        public BPOpenApiPUID Puid { get; set; }

        /// <summary>
        /// 前置流程从哪个节点发起的本流程
        /// </summary>
        [JsonProperty("source_node_name")]
        [XmlElement("source_node_name")]
        public string SourceNodeName { get; set; }

        /// <summary>
        /// 前置流程的PUID。用于串连起两个流程
        /// </summary>
        [JsonProperty("source_puid")]
        [XmlElement("source_puid")]
        public string SourcePuid { get; set; }

        /// <summary>
        /// 子流程的上下文。每一个上下文都使用JSON格式
        /// </summary>
        [JsonProperty("sub_contexts")]
        [XmlArray("sub_contexts")]
        [XmlArrayItem("string")]
        public List<string> SubContexts { get; set; }
    }
}
