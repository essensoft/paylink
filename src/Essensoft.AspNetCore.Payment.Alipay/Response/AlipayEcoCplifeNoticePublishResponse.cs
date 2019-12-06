using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoCplifeNoticePublishResponse.
    /// </summary>
    public class AlipayEcoCplifeNoticePublishResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝平台统一生产的通知公告唯一ID标示.
        /// </summary>
        [JsonPropertyName("notice_id")]
        public string NoticeId { get; set; }
    }
}
