using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdIfaatamMessagenotifySendResponse.
    /// </summary>
    public class AlipaySecurityProdIfaatamMessagenotifySendResponse : AlipayResponse
    {
        /// <summary>
        /// 接口调用返回状态码
        /// </summary>
        [JsonPropertyName("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 接口返回状态码描述
        /// </summary>
        [JsonPropertyName("return_msg")]
        public string ReturnMsg { get; set; }

        /// <summary>
        /// 消息通知是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
