using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceDataMonitordeviceQualitycenterModifyResponse.
    /// </summary>
    public class AlipayCommerceDataMonitordeviceQualitycenterModifyResponse : AlipayResponse
    {
        /// <summary>
        /// error_detail，出错的情况下返回，包含具体信息。
        /// </summary>
        [JsonPropertyName("error_detail")]
        public string ErrorDetail { get; set; }
    }
}
