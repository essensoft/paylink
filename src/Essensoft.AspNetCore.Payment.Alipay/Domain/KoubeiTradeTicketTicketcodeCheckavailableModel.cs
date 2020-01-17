using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeCheckavailableModel Data Structure.
    /// </summary>
    public class KoubeiTradeTicketTicketcodeCheckavailableModel : AlipayObject
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 核销次数(次卡场景使用，要求大于0)，非次卡建议填充1或者不填
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 请求id，唯一标识一次请求
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 口碑商品发货单号
        /// </summary>
        [JsonPropertyName("send_order_no")]
        public string SendOrderNo { get; set; }

        /// <summary>
        /// 发货token
        /// </summary>
        [JsonPropertyName("send_token")]
        public string SendToken { get; set; }

        /// <summary>
        /// 核销门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 外部凭证码
        /// </summary>
        [JsonPropertyName("ticket_code")]
        public string TicketCode { get; set; }
    }
}
