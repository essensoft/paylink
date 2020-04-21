using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherCreateResponse.
    /// </summary>
    public class AlipayOfflineMarketingVoucherCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 活动id，过渡方案的兼容字段
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 券模板id
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
