using System.Collections.Generic;
using Newtonsoft.Json;

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
        [JsonProperty("biz_result")]
        public List<string> BizResult { get; set; }

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
