using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherUseModel Data Structure.
    /// </summary>
    public class AlipayOfflineMarketingVoucherUseModel : AlipayObject
    {
        /// <summary>
        /// 约定的扩展参数
        /// </summary>
        [JsonPropertyName("extend_params")]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 外部活动id
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 外部交易信息
        /// </summary>
        [JsonPropertyName("external_trade_info")]
        public VoucherUserExternalTradeInfo ExternalTradeInfo { get; set; }

        /// <summary>
        /// 外部券码
        /// </summary>
        [JsonPropertyName("external_voucher_code")]
        public string ExternalVoucherCode { get; set; }
    }
}
