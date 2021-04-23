using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInstserviceDeductPayResponse.
    /// </summary>
    public class AlipayEbppInstserviceDeductPayResponse : AlipayResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// true代表受理成功 false代表受理失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
