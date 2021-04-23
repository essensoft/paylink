using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateApplycompetitionWorksSyncModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateApplycompetitionWorksSyncModel : AlipayObject
    {
        /// <summary>
        /// 参赛状态，参赛状态0:已报名，1:已支付，2:已参赛
        /// </summary>
        [JsonPropertyName("apply_status")]
        public string ApplyStatus { get; set; }

        /// <summary>
        /// 文件类型1：图片，2：视频
        /// </summary>
        [JsonPropertyName("file_type")]
        public string FileType { get; set; }

        /// <summary>
        /// 参赛者作品url
        /// </summary>
        [JsonPropertyName("files_url")]
        public string FilesUrl { get; set; }

        /// <summary>
        /// 参赛者id,由支付宝生成
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
