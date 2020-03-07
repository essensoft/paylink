using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppIsvProdmodeCreateResponse.
    /// </summary>
    public class AlipayEbppIsvProdmodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 流程实例ID
        /// </summary>
        [JsonPropertyName("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 创建产品模型成功后返回任务ID
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
