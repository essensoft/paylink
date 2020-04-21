using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VoucherUserExternalTradeInfo Data Structure.
    /// </summary>
    public class VoucherUserExternalTradeInfo : AlipayObject
    {
        /// <summary>
        /// 核销金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 核销时间
        /// </summary>
        [JsonPropertyName("consume_date")]
        public string ConsumeDate { get; set; }

        /// <summary>
        /// 券核销的门店id
        /// </summary>
        [JsonPropertyName("consume_shop_id")]
        public string ConsumeShopId { get; set; }

        /// <summary>
        /// 外部交易号
        /// </summary>
        [JsonPropertyName("external_trade_no")]
        public string ExternalTradeNo { get; set; }
    }
}
