using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCompetitionapplyStatusSyncModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateCompetitionapplyStatusSyncModel : AlipayObject
    {
        /// <summary>
        /// 参赛状态:
        /// </summary>
        [JsonPropertyName("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 参赛者id，由支付宝系统生成，如果需要更改报名状态，需要传此字段
        /// </summary>
        [JsonPropertyName("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 参赛人信息
        /// </summary>
        [JsonPropertyName("participant_info")]
        public ParticipantInfo ParticipantInfo { get; set; }

        /// <summary>
        /// 外部赛事ID
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; }
    }
}
