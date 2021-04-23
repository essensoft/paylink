using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayAccountExrateConfigQueryResponse.
    /// </summary>
    public class AlipayAccountExrateConfigQueryResponse : AlipayResponse
    {
        /// <summary>
        /// scheduler配置的自定义键值对
        /// </summary>
        [JsonPropertyName("task_context")]
        public string TaskContext { get; set; }

        /// <summary>
        /// scheduler的状态码
        /// </summary>
        [JsonPropertyName("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// scheduler的配置类型
        /// </summary>
        [JsonPropertyName("task_type")]
        public string TaskType { get; set; }
    }
}
