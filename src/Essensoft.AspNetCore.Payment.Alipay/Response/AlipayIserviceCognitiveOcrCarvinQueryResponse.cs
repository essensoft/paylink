using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrCarvinQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrCarvinQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 服务id，唯一标示服务请求
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 开放平台trace_id，用于定位问题
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 车辆vin码
        /// </summary>
        [JsonPropertyName("vin")]
        public string Vin { get; set; }
    }
}
