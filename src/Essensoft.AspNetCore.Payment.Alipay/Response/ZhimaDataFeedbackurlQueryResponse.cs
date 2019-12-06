using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaDataFeedbackurlQueryResponse.
    /// </summary>
    public class ZhimaDataFeedbackurlQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 反馈模板地址
        /// </summary>
        [JsonPropertyName("feedback_url")]
        public string FeedbackUrl { get; set; }
    }
}
