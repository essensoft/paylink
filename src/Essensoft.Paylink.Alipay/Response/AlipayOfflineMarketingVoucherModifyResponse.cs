using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherModifyResponse.
    /// </summary>
    public class AlipayOfflineMarketingVoucherModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 券id
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券模板状态,EFFECTIVE=生效，INVALID=失效
        /// </summary>
        [JsonPropertyName("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
