using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportIndustryProxyUseResponse.
    /// </summary>
    public class AlipayCommerceTransportIndustryProxyUseResponse : AlipayResponse
    {
        /// <summary>
        /// 行业代理响应，根据行业场景、行业事件的变化而不同
        /// </summary>
        [JsonPropertyName("industry_response")]
        public string IndustryResponse { get; set; }
    }
}
