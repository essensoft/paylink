using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// WorkShiftParam Data Structure.
    /// </summary>
    public class WorkShiftParam : AlipayObject
    {
        /// <summary>
        /// 扩展参数，json格式，由双方约定取值
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 排班优化类型
        /// </summary>
        [JsonPropertyName("optimize_type")]
        public long OptimizeType { get; set; }

        /// <summary>
        /// 该日期使用的排班服务任务ID
        /// </summary>
        [JsonPropertyName("work_schedule_service_task_id")]
        public string WorkScheduleServiceTaskId { get; set; }

        /// <summary>
        /// 待轮班的日期（yyyyMMdd）
        /// </summary>
        [JsonPropertyName("work_shift_date")]
        public string WorkShiftDate { get; set; }
    }
}
