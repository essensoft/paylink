using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenApiResponseHeader Data Structure.
    /// </summary>
    public class OpenApiResponseHeader : AlipayObject
    {
        /// <summary>
        /// 会话id，对应请求中的conversation_id，若请求中conversation_id非空，则该值非空
        /// </summary>
        [JsonPropertyName("conversation_id")]
        public string ConversationId { get; set; }

        /// <summary>
        /// 响应id，对应请求中的request_id。如果请求中request_id非空，则response_id非空。
        /// </summary>
        [JsonPropertyName("response_id")]
        public string ResponseId { get; set; }

        /// <summary>
        /// 自定义状态码
        /// </summary>
        [JsonPropertyName("status_code")]
        public string StatusCode { get; set; }

        /// <summary>
        /// 状态信息
        /// </summary>
        [JsonPropertyName("status_message")]
        public string StatusMessage { get; set; }

        /// <summary>
        /// 子状态码
        /// </summary>
        [JsonPropertyName("sub_status_code")]
        public string SubStatusCode { get; set; }
    }
}
