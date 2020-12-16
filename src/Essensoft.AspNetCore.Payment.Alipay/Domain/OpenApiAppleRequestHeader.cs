using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OpenApiAppleRequestHeader Data Structure.
    /// </summary>
    public class OpenApiAppleRequestHeader : AlipayObject
    {
        /// <summary>
        /// 会话id，一般会在响应中带回给商户。
        /// </summary>
        [JsonPropertyName("conversation_id")]
        public string ConversationId { get; set; }

        /// <summary>
        /// 请求id，一般会在相应中带回给商户
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
