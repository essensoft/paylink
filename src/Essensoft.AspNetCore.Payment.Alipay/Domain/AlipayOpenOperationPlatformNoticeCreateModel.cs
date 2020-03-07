using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenOperationPlatformNoticeCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenOperationPlatformNoticeCreateModel : AlipayObject
    {
        /// <summary>
        /// 站内信内容字段
        /// </summary>
        [JsonPropertyName("notice_content")]
        public string NoticeContent { get; set; }

        /// <summary>
        /// 站内信title字段
        /// </summary>
        [JsonPropertyName("notice_title")]
        public string NoticeTitle { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
