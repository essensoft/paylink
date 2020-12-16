using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneTaskflowBatchQueryResponse.
    /// </summary>
    public class AlipayInsSceneTaskflowBatchQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 任务流水列表
        /// </summary>
        [JsonPropertyName("task_flow_list")]
        public List<InsSceneTaskFlowDTO> TaskFlowList { get; set; }
    }
}
