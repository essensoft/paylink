using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdCtidVerifyResponse.
    /// </summary>
    public class AlipaySecurityProdCtidVerifyResponse : AlipayResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果码描述
        /// </summary>
        [JsonPropertyName("result_desc")]
        public string ResultDesc { get; set; }
    }
}
