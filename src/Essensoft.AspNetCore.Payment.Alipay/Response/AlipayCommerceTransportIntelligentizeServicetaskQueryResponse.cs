using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportIntelligentizeServicetaskQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportIntelligentizeServicetaskQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 服务任务结束时间，处理完成或处理失败前为空（yyyy-MM-dd HH24:mi:ss）
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展信息，json格式，由双方约定取值
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 服务任务结果码，发生异常时非空
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 服务任务结果信息，发生异常时非空
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }

        /// <summary>
        /// 服务任务ID
        /// </summary>
        [JsonPropertyName("service_task_id")]
        public string ServiceTaskId { get; set; }

        /// <summary>
        /// 服务任务执行结果，尚未处理成功或处理失败时为空
        /// </summary>
        [JsonPropertyName("service_task_result")]
        public string ServiceTaskResult { get; set; }

        /// <summary>
        /// 服务任务状态（INIT-初始，PROCESSING-处理中，SUCCESS-成功，FAILED-失败）
        /// </summary>
        [JsonPropertyName("service_task_status")]
        public string ServiceTaskStatus { get; set; }

        /// <summary>
        /// 服务任务类型
        /// </summary>
        [JsonPropertyName("service_task_type")]
        public string ServiceTaskType { get; set; }

        /// <summary>
        /// 服务任务开始时间，开始处理之前为空（yyyy-MM-dd HH24:mi:ss）
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 子任务集合
        /// </summary>
        [JsonPropertyName("sub_task_list")]
        public List<ServiceSubTaskQueryOpenapiResult> SubTaskList { get; set; }
    }
}
