using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateInfoScoreQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateInfoScoreQueryModel : AlipayObject
    {
        /// <summary>
        /// 扩展信息，json格式字符串
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 参赛者ID
        /// </summary>
        [JsonPropertyName("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 外部赛事ID
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; }
    }
}
