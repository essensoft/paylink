using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceSgxGatewayQueryResponse.
    /// </summary>
    public class AlipayDataAiserviceSgxGatewayQueryResponse : AlipayResponse
    {
        /// <summary>
        /// request_uuid ：对应用户请求的唯一id，用于定位请求具体对应到哪一次调用。所有调用场景都会返回改值 。该值由用户请求中传入
        /// </summary>
        [JsonPropertyName("request_uuid")]
        public string RequestUuid { get; set; }

        /// <summary>
        /// result : 业务处理结果json字符串，所有场景都会返回该值。该值由具体调用接口的返回值决定。
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
