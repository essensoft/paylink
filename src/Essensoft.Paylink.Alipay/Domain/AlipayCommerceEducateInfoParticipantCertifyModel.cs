using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateInfoParticipantCertifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateInfoParticipantCertifyModel : AlipayObject
    {
        /// <summary>
        /// 参赛者信息
        /// </summary>
        [JsonPropertyName("participant_info")]
        public List<ParticipantInfo> ParticipantInfo { get; set; }

        /// <summary>
        /// 外部赛事ID
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; }
    }
}
