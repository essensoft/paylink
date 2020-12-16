using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppAppcontentFunctionModifyResponse.
    /// </summary>
    public class AlipayOpenAppAppcontentFunctionModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }
    }
}
