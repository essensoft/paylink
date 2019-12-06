using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPassSyncAddResponse.
    /// </summary>
    public class AlipayPassSyncAddResponse : AlipayResponse
    {
        /// <summary>
        /// 成功时返回的业务参数信息。
        /// </summary>
        [JsonPropertyName("biz_result")]
        public string BizResult { get; set; }

        /// <summary>
        /// 当新增alipass不成功时，产生的错误码。
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 成功标识
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
