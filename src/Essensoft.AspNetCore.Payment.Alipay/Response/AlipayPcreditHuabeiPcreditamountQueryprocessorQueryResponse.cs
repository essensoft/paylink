using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditamountQueryprocessorQueryResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditamountQueryprocessorQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 报错原因
        /// </summary>
        [JsonPropertyName("error_context")]
        public string ErrorContext { get; set; }

        /// <summary>
        /// 响应体
        /// </summary>
        [JsonPropertyName("response")]
        public TbapiQueryAmountResponse Response { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
