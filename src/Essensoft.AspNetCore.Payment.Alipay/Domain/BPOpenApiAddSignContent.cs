using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BPOpenApiAddSignContent Data Structure.
    /// </summary>
    public class BPOpenApiAddSignContent : AlipayObject
    {
        /// <summary>
        /// 自定义的条件跳转。JSON格式
        /// </summary>
        [JsonPropertyName("additional_lines")]
        public List<string> AdditionalLines { get; set; }

        /// <summary>
        /// 任务处理人的域账号列表
        /// </summary>
        [JsonPropertyName("assignee")]
        public string Assignee { get; set; }

        /// <summary>
        /// 自定义操作
        /// </summary>
        [JsonPropertyName("deal_actions")]
        public string DealActions { get; set; }

        /// <summary>
        /// 任务处理链接。如果不填，则使用流程平台默认地址
        /// </summary>
        [JsonPropertyName("deal_url")]
        public string DealUrl { get; set; }

        /// <summary>
        /// 详情查看地址。如果不填写，则使用流程平台默认详情地址
        /// </summary>
        [JsonPropertyName("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 处理节点展示名称
        /// </summary>
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }
    }
}
