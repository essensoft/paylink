using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceDeployorderResultSendResponse.
    /// </summary>
    public class AlipayDataDataserviceDeployorderResultSendResponse : AlipayResponse
    {
        /// <summary>
        /// 处理是否成功
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
