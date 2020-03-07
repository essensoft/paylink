using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserMemberGcwtaskQueryResponse.
    /// </summary>
    public class AlipayUserMemberGcwtaskQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码，如果失败会返回失败的结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 广场舞大赛任务（做任务领票数）
        /// </summary>
        [JsonPropertyName("square_dance_task_info_list")]
        public List<SquareDanceTaskInfo> SquareDanceTaskInfoList { get; set; }

        /// <summary>
        /// true推进任务成功，false推进任务失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
