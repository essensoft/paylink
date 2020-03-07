using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrBankcardQueryResponse.
    /// </summary>
    public class AlipayIserviceCognitiveOcrBankcardQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 银行卡号
        /// </summary>
        [JsonPropertyName("card_num")]
        public string CardNum { get; set; }

        /// <summary>
        /// 服务器内部请求id
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
    }
}
