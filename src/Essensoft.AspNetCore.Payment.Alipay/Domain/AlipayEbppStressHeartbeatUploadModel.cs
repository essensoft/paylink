using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppStressHeartbeatUploadModel Data Structure.
    /// </summary>
    public class AlipayEbppStressHeartbeatUploadModel : AlipayObject
    {
        /// <summary>
        /// 引擎错误原因
        /// </summary>
        [JsonPropertyName("exception")]
        public string Exception { get; set; }

        /// <summary>
        /// 压测实例的唯一标识
        /// </summary>
        [JsonPropertyName("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 机器状态
        /// </summary>
        [JsonPropertyName("machine_status")]
        public string MachineStatus { get; set; }

        /// <summary>
        /// json 格式的上报信息详情列表
        /// </summary>
        [JsonPropertyName("report_detail")]
        public List<StressRequestItem> ReportDetail { get; set; }

        /// <summary>
        /// 上报时间
        /// </summary>
        [JsonPropertyName("report_time")]
        public string ReportTime { get; set; }

        /// <summary>
        /// 压测任务的唯一标识
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
