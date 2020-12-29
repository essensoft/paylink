using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdEventActionModifyResponse.
    /// </summary>
    public class AlipaySecurityProdEventActionModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 返回状态码 200 成功 500 失败
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 返回描述
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }
    }
}
