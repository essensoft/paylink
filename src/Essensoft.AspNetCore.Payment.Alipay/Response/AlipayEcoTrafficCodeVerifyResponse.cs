using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoTrafficCodeVerifyResponse.
    /// </summary>
    public class AlipayEcoTrafficCodeVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 解码是否成功
        /// </summary>
        [JsonPropertyName("decode_success")]
        public string DecodeSuccess { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 解析模式：QRCODE/RECORD
        /// </summary>
        [JsonPropertyName("parse_mode")]
        public string ParseMode { get; set; }

        /// <summary>
        /// 描述本次执行结果详情
        /// </summary>
        [JsonPropertyName("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 是否调用成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 验码是否成功
        /// </summary>
        [JsonPropertyName("verify_success")]
        public string VerifySuccess { get; set; }
    }
}
