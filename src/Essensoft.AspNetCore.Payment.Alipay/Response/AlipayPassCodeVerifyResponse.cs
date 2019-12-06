using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPassCodeVerifyResponse.
    /// </summary>
    public class AlipayPassCodeVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 返回核销流水号及操作结果
        /// </summary>
        [JsonPropertyName("biz_result")]
        public string BizResult { get; set; }

        /// <summary>
        /// 返回码.
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 是否发码成功的标识。
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
