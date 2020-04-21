using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPassFileAddResponse.
    /// </summary>
    public class AlipayPassFileAddResponse : AlipayResponse
    {
        /// <summary>
        /// 业务结果
        /// </summary>
        [JsonPropertyName("biz_result")]
        public string BizResult { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 是否成功标识:T-成功；F-失败
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
