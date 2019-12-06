using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTrustUserReportGetResponse.
    /// </summary>
    public class AlipayTrustUserReportGetResponse : AlipayResponse
    {
        /// <summary>
        /// 报告内容，格式详见示例代码
        /// </summary>
        [JsonPropertyName("report")]
        public string Report { get; set; }
    }
}
