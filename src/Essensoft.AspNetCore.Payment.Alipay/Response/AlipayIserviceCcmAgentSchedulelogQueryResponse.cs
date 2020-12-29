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

        /// <summary>
        /// 查询结果的页码
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询时设置的每页记录数
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条目数
        /// </summary>
        [JsonPropertyName("total_count")]
        public long TotalCount { get; set; }
    }
}
