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
        /// 用户报名备注信息，key为field_name值，value为用户选择的备注信息值    当key为user_defined时，表示用户自定义备注
        /// </summary>
        [JsonPropertyName("apply_note_info")]
        public string ApplyNoteInfo { get; set; }

        /// <summary>
        /// 扩展信息JSON格式字符串
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 推广方编码
        /// </summary>
        [JsonPropertyName("from_code")]
        public string FromCode { get; set; }

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
