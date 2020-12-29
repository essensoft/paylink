using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCcmAgentSchedulelogQueryModel Data Structure.
    /// </summary>
    public class AlipayIserviceCcmAgentSchedulelogQueryModel : AlipayObject
    {
        /// <summary>
        /// 客服id集合,限制最多100个id,不传查询部门下所有客服的状态变更流水日志
        /// </summary>
        [JsonPropertyName("agent_ids")]
        public List<string> AgentIds { get; set; }

        /// <summary>
        /// 部门id（即租户实例ID、数据权限ID）
        /// </summary>
        [JsonPropertyName("ccs_instance_id")]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 客服状态变更结束时间,开始时间与结束时间间隔不能超过1天,采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd'T'HH:mm:ss'Z'
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 查询条数,最大100, 不传默认100
        /// </summary>
        [JsonPropertyName("limit")]
        public long Limit { get; set; }

        /// <summary>
        /// 查询结果的页码，起始值为 1，默认值为 1
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页查询时设置的每页记录数，最大值 100 行，默认为 100
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 起始id,分页导出的起始客服状态变更流水id,第一页传0,翻页时传上一页结果的最大id
        /// </summary>
        [JsonPropertyName("start_id")]
        public long StartId { get; set; }

        /// <summary>
        /// 客服状态变更开始时间,采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd'T'HH:mm:ss'Z'
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }
    }
}
