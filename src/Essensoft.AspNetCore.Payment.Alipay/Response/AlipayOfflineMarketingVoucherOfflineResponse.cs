using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherOfflineResponse.
    /// </summary>
    public class AlipayOfflineMarketingVoucherOfflineResponse : AlipayResponse
    {
        /// <summary>
        /// 券模板编号
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券模板状态。EFFECTIVE=生效，INVALID=失效。
        /// </summary>
        [JsonPropertyName("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
