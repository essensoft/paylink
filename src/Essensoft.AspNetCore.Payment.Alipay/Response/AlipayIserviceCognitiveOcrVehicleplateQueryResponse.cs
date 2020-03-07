using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrVehicleplateQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrVehicleplateQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 服务识别失败后对应的详细错误原因
        /// </summary>
        [JsonPropertyName("error_content")]
        public string ErrorContent { get; set; }

        /// <summary>
        /// 识别正确概率
        /// </summary>
        [JsonPropertyName("prob")]
        public string Prob { get; set; }

        /// <summary>
        /// 服务器id
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// true: 识别成功  false: 识别失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 开放平台trace_id
        /// </summary>
        [JsonPropertyName("trace_id")]
        public string TraceId { get; set; }

        /// <summary>
        /// 车牌号码
        /// </summary>
        [JsonPropertyName("txt")]
        public string Txt { get; set; }
    }
}
