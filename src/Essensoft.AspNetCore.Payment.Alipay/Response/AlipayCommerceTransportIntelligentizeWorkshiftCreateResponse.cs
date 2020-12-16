using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeWorkshiftCreateResponse.
    /// </summary>
    public class AlipayCommerceTransportIntelligentizeWorkshiftCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展信息，json格式，由双方约定取值
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 服务任务ID，用于查询服务任务状态和结果
        /// </summary>
        [JsonPropertyName("service_task_id")]
        public string ServiceTaskId { get; set; }

        /// <summary>
        /// 服务任务类型
        /// </summary>
        [JsonPropertyName("service_task_type")]
        public string ServiceTaskType { get; set; }
    }
}
