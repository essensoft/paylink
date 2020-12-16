using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AgentScheduleLog Data Structure.
    /// </summary>
    public class AgentScheduleLog : AlipayObject
    {
        /// <summary>
        /// 客服id
        /// </summary>
        [JsonPropertyName("agent_id")]
        public string AgentId { get; set; }

        /// <summary>
        /// 客服名称
        /// </summary>
        [JsonPropertyName("agent_name")]
        public string AgentName { get; set; }

        /// <summary>
        /// 状态变更发生时间,采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd'T'HH:mm:ss'Z'
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 状态持续时长,单位秒
        /// </summary>
        [JsonPropertyName("duration")]
        public long Duration { get; set; }

        /// <summary>
        /// 状态变更结束时间,采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd'T'HH:mm:ss'Z'
        /// </summary>
        [JsonPropertyName("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// isv或商户系统中对应的客服工号
        /// </summary>
        [JsonPropertyName("external_user_no")]
        public string ExternalUserNo { get; set; }

        /// <summary>
        /// 客服状态变更流水id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 变更前状态
        /// </summary>
        [JsonPropertyName("last_status")]
        public string LastStatus { get; set; }

        /// <summary>
        /// 状态变更开始时间,采用UTC时间，按照ISO8601标准表示，格式为：yyyy-MM-dd'T'HH:mm:ss'Z'
        /// </summary>
        [JsonPropertyName("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 变更后状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
