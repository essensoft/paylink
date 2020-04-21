using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherStatusQueryResponse.
    /// </summary>
    public class AlipayOfflineMarketingVoucherStatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 券模板id
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
