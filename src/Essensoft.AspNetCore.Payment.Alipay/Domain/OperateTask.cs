using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OperateTask Data Structure.
    /// </summary>
    public class OperateTask : AlipayObject
    {
        /// <summary>
        /// 操作参数，json格式字符串，根据operation_type值不同，传入不同的值。 当operation_type=RESPONSE时，operation_params不传； 当operation_type=DEAL时，传入的参数包括feedback_code(反馈code)、feedback_remark(反馈备注)； 当operation_type=REMARK时，传入的参数包括remark_content(备注内容)
        /// </summary>
        [JsonPropertyName("operation_params")]
        public string OperationParams { get; set; }

        /// <summary>
        /// 操作类型: RESPONSE：任务响应 DEAL：任务处理 REMARK：任务备注
        /// </summary>
        [JsonPropertyName("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 操作任务id
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
