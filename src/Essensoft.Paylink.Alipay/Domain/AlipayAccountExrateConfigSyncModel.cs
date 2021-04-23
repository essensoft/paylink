using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayAccountExrateConfigSyncModel Data Structure.
    /// </summary>
    public class AlipayAccountExrateConfigSyncModel : AlipayObject
    {
        /// <summary>
        /// 自定义规则，字符串的形式。国际要同步到主站的拓展信息
        /// </summary>
        [JsonPropertyName("task_context")]
        public string TaskContext { get; set; }

        /// <summary>
        /// 调度任务状态
        /// </summary>
        [JsonPropertyName("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 配置信息的调度类型
        /// </summary>
        [JsonPropertyName("task_type")]
        public string TaskType { get; set; }
    }
}
