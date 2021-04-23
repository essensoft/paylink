using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateInfoApplycancelCertifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateInfoApplycancelCertifyModel : AlipayObject
    {
        /// <summary>
        /// 取消原因编码
        /// </summary>
        [JsonPropertyName("cause_code")]
        public string CauseCode { get; set; }

        /// <summary>
        /// 取消原因描述
        /// </summary>
        [JsonPropertyName("cause_msg")]
        public string CauseMsg { get; set; }

        /// <summary>
        /// 扩展信息json格式字符串
        /// </summary>
        [JsonPropertyName("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 参赛者id
        /// </summary>
        [JsonPropertyName("participant_id")]
        public string ParticipantId { get; set; }

        /// <summary>
        /// 外部赛事id
        /// </summary>
        [JsonPropertyName("source_id")]
        public string SourceId { get; set; }
    }
}
