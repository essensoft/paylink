using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicMessageContentModifyResponse.
    /// </summary>
    public class AlipayOpenPublicMessageContentModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 内容id
        /// </summary>
        [JsonPropertyName("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 内容详情内链url
        /// </summary>
        [JsonPropertyName("content_url")]
        public string ContentUrl { get; set; }
    }
}
