using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceOperationIsvServiceSubmitResponse.
    /// </summary>
    public class AlipayCommerceOperationIsvServiceSubmitResponse : AlipayResponse
    {
        /// <summary>
        /// id （后续消息标识对应服务）
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
