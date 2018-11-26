using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BPOpenApiAddSignContent Data Structure.
    /// </summary>
    [Serializable]
    public class BPOpenApiAddSignContent : AlipayObject
    {
        /// <summary>
        /// 自定义的条件跳转。JSON格式
        /// </summary>
        [JsonProperty("additional_lines")]
        [XmlArray("additional_lines")]
        [XmlArrayItem("string")]
        public List<string> AdditionalLines { get; set; }

        /// <summary>
        /// 任务处理人的域账号列表
        /// </summary>
        [JsonProperty("assignee")]
        [XmlElement("assignee")]
        public string Assignee { get; set; }

        /// <summary>
        /// 自定义操作
        /// </summary>
        [JsonProperty("deal_actions")]
        [XmlElement("deal_actions")]
        public string DealActions { get; set; }

        /// <summary>
        /// 任务处理链接。如果不填，则使用流程平台默认地址
        /// </summary>
        [JsonProperty("deal_url")]
        [XmlElement("deal_url")]
        public string DealUrl { get; set; }

        /// <summary>
        /// 详情查看地址。如果不填写，则使用流程平台默认详情地址
        /// </summary>
        [JsonProperty("detail_url")]
        [XmlElement("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 处理节点展示名称
        /// </summary>
        [JsonProperty("display_name")]
        [XmlElement("display_name")]
        public string DisplayName { get; set; }
    }
}
