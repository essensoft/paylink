using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TaskOperationLog Data Structure.
    /// </summary>
    public class TaskOperationLog : AlipayObject
    {
        /// <summary>
        /// 操作时间，yyyy-MM-dd HH:mm:ss格式字符串
        /// </summary>
        [JsonPropertyName("gmt_opration")]
        public string GmtOpration { get; set; }

        /// <summary>
        /// 操作详情描述
        /// </summary>
        [JsonPropertyName("operation_desc")]
        public string OperationDesc { get; set; }

        /// <summary>
        /// 操作备注
        /// </summary>
        [JsonPropertyName("operation_memo")]
        public string OperationMemo { get; set; }

        /// <summary>
        /// 操作类型: CREATE：任务创建, MANUAL:手工添加动态, TRANSFER：任务转派, URGE：任务催办, RESPONSE：任务响应, DEAL：任务处理, EXP_RESUME：异常恢复
        /// </summary>
        [JsonPropertyName("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 操作人id
        /// </summary>
        [JsonPropertyName("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作人名称
        /// </summary>
        [JsonPropertyName("operator_nick")]
        public string OperatorNick { get; set; }
    }
}
