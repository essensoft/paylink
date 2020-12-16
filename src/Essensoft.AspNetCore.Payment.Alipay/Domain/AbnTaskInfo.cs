using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AbnTaskInfo Data Structure.
    /// </summary>
    public class AbnTaskInfo : AlipayObject
    {
        /// <summary>
        /// 任务扩展信息，json格式字符串，不同的task_type对应不同的扩展信息。
        /// </summary>
        [JsonPropertyName("extens_info")]
        public string ExtensInfo { get; set; }

        /// <summary>
        /// 创建时间，yyyy-MM-dd HH:mm:ss格式字符串
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间，yyyy-MM-dd HH:mm:ss格式字符串
        /// </summary>
        [JsonPropertyName("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 处理人id，多个时使用英文逗号","分隔
        /// </summary>
        [JsonPropertyName("handler_id")]
        public string HandlerId { get; set; }

        /// <summary>
        /// 处理人昵称，多个时使用英文逗号","分隔
        /// </summary>
        [JsonPropertyName("handler_nick")]
        public string HandlerNick { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [JsonPropertyName("task_desc")]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }

        /// <summary>
        /// 任务级别： 紧急、高、中、低
        /// </summary>
        [JsonPropertyName("task_level")]
        public string TaskLevel { get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonPropertyName("task_name")]
        public string TaskName { get; set; }

        /// <summary>
        /// 任务操作记录集合
        /// </summary>
        [JsonPropertyName("task_operation_logs")]
        public List<TaskOperationLog> TaskOperationLogs { get; set; }

        /// <summary>
        /// 任务状态: CREATED：待响应， RESPONSED：处理中 DEALED：已完成
        /// </summary>
        [JsonPropertyName("task_status")]
        public string TaskStatus { get; set; }

        /// <summary>
        /// 任务类型 MERCHANT_TRADE_DROPZERO：商户交易跌零任务
        /// </summary>
        [JsonPropertyName("task_type")]
        public string TaskType { get; set; }
    }
}
