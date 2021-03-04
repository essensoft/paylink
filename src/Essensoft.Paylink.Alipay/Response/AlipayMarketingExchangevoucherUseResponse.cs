using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingExchangevoucherUseResponse.
    /// </summary>
    public class AlipayMarketingExchangevoucherUseResponse : AlipayResponse
    {
        /// <summary>
        /// 被核销的券ID
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
