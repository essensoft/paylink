using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportCarrentalServiceSubmitResponse.
    /// </summary>
    public class AlipayCommerceTransportCarrentalServiceSubmitResponse : AlipayResponse
    {
        /// <summary>
        /// 请求ID
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
