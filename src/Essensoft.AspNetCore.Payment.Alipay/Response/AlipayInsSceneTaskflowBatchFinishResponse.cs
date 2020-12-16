using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneTaskflowBatchFinishResponse.
    /// </summary>
    public class AlipayInsSceneTaskflowBatchFinishResponse : AlipayResponse
    {
        /// <summary>
        /// 任务流水列表
        /// </summary>
        [JsonPropertyName("task_flow_id_list")]
        public List<string> TaskFlowIdList { get; set; }
    }
}
