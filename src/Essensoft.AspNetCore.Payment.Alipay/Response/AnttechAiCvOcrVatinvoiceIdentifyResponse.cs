using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AnttechAiCvOcrVatinvoiceIdentifyResponse.
    /// </summary>
    public class AnttechAiCvOcrVatinvoiceIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 算法错误信息
        /// </summary>
        [JsonPropertyName("algo_msg")]
        public string AlgoMsg { get; set; }

        /// <summary>
        /// 算法异常错误码
        /// </summary>
        [JsonPropertyName("algo_ret")]
        public string AlgoRet { get; set; }

        /// <summary>
        /// 框架错误信息
        /// </summary>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// 算法结果,JSON String
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 框架inference服务错误码，0为正常
        /// </summary>
        [JsonPropertyName("ret")]
        public string Ret { get; set; }
    }
}
