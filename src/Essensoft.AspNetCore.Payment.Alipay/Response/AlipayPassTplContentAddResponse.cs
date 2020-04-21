using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPassTplContentAddResponse.
    /// </summary>
    public class AlipayPassTplContentAddResponse : AlipayResponse
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
