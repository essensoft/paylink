using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmOlsChatrecordQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmOlsChatrecordQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 客服id
        /// </summary>
        [JsonPropertyName("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 客服昵称
        /// </summary>
        [JsonPropertyName("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 多个层级类目信息
        /// </summary>
        [JsonPropertyName("categories")]
        public string Categories { get; set; }

        /// <summary>
        /// 在线技能组id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 在线技能组名称
        /// </summary>
        [JsonPropertyName("group_name")]
        public string GroupName { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 聊天消息列表
        /// </summary>
        [JsonPropertyName("messages")]
        public List<ChatMessage> Messages { get; set; }

        /// <summary>
        /// 满意度。 0：非常满意 1：满意 2：一般 3：不满意 4：非常不满意
        /// </summary>
        [JsonPropertyName("satisfaction")]
        public string Satisfaction { get; set; }

        /// <summary>
        /// 服务记录状态。1：待处理 2：暂存 3：完结 4：废除 5：无效 6：未知
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 在线服务时长，单位秒
        /// </summary>
        [JsonPropertyName("talk_duration")]
        public long TalkDuration { get; set; }

        /// <summary>
        /// 访客归属地
        /// </summary>
        [JsonPropertyName("visitor_province")]
        public string VisitorProvince { get; set; }
    }
}
