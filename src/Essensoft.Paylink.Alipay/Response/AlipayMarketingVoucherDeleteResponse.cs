using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingVoucherDeleteResponse.
    /// </summary>
    public class AlipayMarketingVoucherDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 本张券的原始面额，单位元
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }
    }
}
