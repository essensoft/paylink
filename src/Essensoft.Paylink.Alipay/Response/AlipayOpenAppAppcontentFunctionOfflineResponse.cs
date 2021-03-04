using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentFunctionOfflineResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentFunctionOfflineResponse : AlipayResponse
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }
    }
}
