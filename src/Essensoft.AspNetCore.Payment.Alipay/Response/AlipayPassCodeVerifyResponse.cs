using Newtonsoft.Json;

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
        [JsonProperty("biz_result")]
        public string BizResult { get; set; }

        /// <summary>
        /// 返回码.
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 是否发码成功的标识。
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}
