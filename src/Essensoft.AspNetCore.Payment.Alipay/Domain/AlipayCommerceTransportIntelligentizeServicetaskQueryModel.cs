using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeServicetaskQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportIntelligentizeServicetaskQueryModel : AlipayObject
    {
        /// <summary>
        /// 公交企业ID
        /// </summary>
        [JsonPropertyName("corp_id")]
        public string CorpId { get; set; }

        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 请求ID，唯一标识一次请求，由调用方自行确保唯一性
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务任务ID
        /// </summary>
        [JsonPropertyName("service_task_id")]
        public string ServiceTaskId { get; set; }
    }
}
