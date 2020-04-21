using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertMissionResponse Data Structure.
    /// </summary>
    public class KbAdvertMissionResponse : AlipayObject
    {
        /// <summary>
        /// 任务领取时间
        /// </summary>
        [JsonPropertyName("gmt_claimed")]
        public string GmtClaimed { get; set; }

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
        /// 任务ID
        /// </summary>
        [JsonPropertyName("mission_id")]
        public string MissionId { get; set; }

        /// <summary>
        /// 推广状态  EFFECTIVE-有效  INVALID-无效
        /// </summary>
        [JsonPropertyName("promote_status")]
        public string PromoteStatus { get; set; }

        /// <summary>
        /// 任务标的列表
        /// </summary>
        [JsonPropertyName("subjects")]
        public List<KbAdvertSubjectResponse> Subjects { get; set; }
    }
}
