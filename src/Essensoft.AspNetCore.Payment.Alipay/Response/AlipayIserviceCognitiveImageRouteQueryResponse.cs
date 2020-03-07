using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveImageRouteQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveImageRouteQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误详细描述
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 业务识别内容
        /// </summary>
        [JsonPropertyName("res")]
        public string Res { get; set; }

        /// <summary>
        /// true: 成功  false:失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
