using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySocialBaseContentlibStandardvideoauditSendResponse.
    /// </summary>
    public class AlipaySocialBaseContentlibStandardvideoauditSendResponse : AlipayResponse
    {
        /// <summary>
        /// result_msg为请求openAPI接口后返回的结果message
        /// </summary>
        [JsonPropertyName("result_msg")]
        public string ResultMsg { get; set; }
    }
}
