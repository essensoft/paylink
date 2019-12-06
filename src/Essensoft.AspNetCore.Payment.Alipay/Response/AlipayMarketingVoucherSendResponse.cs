using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingVoucherSendResponse.
    /// </summary>
    public class AlipayMarketingVoucherSendResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 券ID
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
