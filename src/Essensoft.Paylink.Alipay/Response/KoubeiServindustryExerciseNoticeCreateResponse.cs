using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiServindustryExerciseNoticeCreateResponse.
    /// </summary>
    public class KoubeiServindustryExerciseNoticeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 通知ID
        /// </summary>
        [JsonPropertyName("notice_id")]
        public string NoticeId { get; set; }
    }
}
