using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertMissionQueryResponse Data Structure.
    /// </summary>
    public class KbAdvertMissionQueryResponse : AlipayObject
    {
        /// <summary>
        /// 任务结束时间
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 任务开始时间
        /// </summary>
        [JsonPropertyName("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 分佣任务ID
        /// </summary>
        [JsonPropertyName("mission_id")]
        public string MissionId { get; set; }

        /// <summary>
        /// 推广状态  EFFECTIVE-有效  INVALID-无效
        /// </summary>
        [JsonPropertyName("promote_status")]
        public string PromoteStatus { get; set; }

        /// <summary>
        /// 分佣标的信息
        /// </summary>
        [JsonPropertyName("subjects")]
        public List<KbAdvertMissionSubject> Subjects { get; set; }
    }
}
