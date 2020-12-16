using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceAbntaskModifyResponse.
    /// </summary>
    public class AlipayCommerceAbntaskModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 操作失败任务数量
        /// </summary>
        [JsonPropertyName("fail_count")]
        public long FailCount { get; set; }

        /// <summary>
        /// 失败任务明细列表
        /// </summary>
        [JsonPropertyName("fail_task_details")]
        public List<FailTaskDetail> FailTaskDetails { get; set; }

        /// <summary>
        /// 操作成功任务数量
        /// </summary>
        [JsonPropertyName("success_count")]
        public long SuccessCount { get; set; }
    }
}
