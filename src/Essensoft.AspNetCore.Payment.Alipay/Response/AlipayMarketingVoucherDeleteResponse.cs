using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
