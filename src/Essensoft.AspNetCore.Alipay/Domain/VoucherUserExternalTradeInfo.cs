using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// VoucherUserExternalTradeInfo Data Structure.
    /// </summary>
    public class VoucherUserExternalTradeInfo : AlipayObject
    {
        /// <summary>
        /// 核销金额
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 核销时间
        /// </summary>
        [JsonProperty("consume_date")]
        public string ConsumeDate { get; set; }

        /// <summary>
        /// 券核销的门店id
        /// </summary>
        [JsonProperty("consume_shop_id")]
        public string ConsumeShopId { get; set; }

        /// <summary>
        /// 外部交易号
        /// </summary>
        [JsonProperty("external_trade_no")]
        public string ExternalTradeNo { get; set; }
    }
}
