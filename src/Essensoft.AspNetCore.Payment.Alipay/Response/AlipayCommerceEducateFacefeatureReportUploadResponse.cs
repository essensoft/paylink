using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureReportUploadResponse.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureReportUploadResponse : AlipayResponse
    {
        /// <summary>
        /// 上报成功失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
