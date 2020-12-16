using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInstserviceDeductSignResponse.
    /// </summary>
    public class AlipayEbppInstserviceDeductSignResponse : AlipayResponse
    {
        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 流程ID用于校验
        /// </summary>
        [JsonPropertyName("process_id")]
        public string ProcessId { get; set; }
    }
}
