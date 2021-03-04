using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDiscoveryTaxiOrderConfirmResponse.
    /// </summary>
    public class AlipayDiscoveryTaxiOrderConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }
    }
}
