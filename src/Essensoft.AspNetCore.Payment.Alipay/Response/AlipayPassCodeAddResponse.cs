using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPassCodeAddResponse.
    /// </summary>
    public class AlipayPassCodeAddResponse : AlipayResponse
    {
        /// <summary>
        /// 成功时返回业务参数
        /// </summary>
        [JsonPropertyName("biz_result")]
        public List<string> BizResult { get; set; }

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
