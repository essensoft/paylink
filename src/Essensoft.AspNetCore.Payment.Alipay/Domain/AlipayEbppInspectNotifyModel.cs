using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInspectNotifyModel Data Structure.
    /// </summary>
    public class AlipayEbppInspectNotifyModel : AlipayObject
    {
        /// <summary>
        /// 引擎函数名称
        /// </summary>
        [JsonPropertyName("function_name")]
        public string FunctionName { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonPropertyName("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 检测日志链接
        /// </summary>
        [JsonPropertyName("log_url")]
        public string LogUrl { get; set; }

        /// <summary>
        /// 引擎检测结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 任务执行状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 时间节点描述
        /// </summary>
        [JsonPropertyName("timing")]
        public string Timing { get; set; }
    }
}
