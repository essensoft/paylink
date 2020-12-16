using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCcmAgentSchedulelogQueryResponse.
    /// </summary>
    public class AlipayIserviceCcmAgentSchedulelogQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 客服状态变更流水日志集合
        /// </summary>
        [JsonPropertyName("agent_schedule_logs")]
        public AgentScheduleLog AgentScheduleLogs { get; set; }
    }
}
