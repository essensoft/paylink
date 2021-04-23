using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TradeInformation Data Structure.
    /// </summary>
    public class TradeInformation : AlipayObject
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        [JsonPropertyName("commodity_name")]
        public string CommodityName { get; set; }

        /// <summary>
        /// 币种
        /// </summary>
        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 订单金额，币种最小单位，如果是CNY，则单位分
        /// </summary>
        [JsonPropertyName("order_amount")]
        public string OrderAmount { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }
    }
}
