using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeTicketSendCloseModel Data Structure.
    /// </summary>
    public class KoubeiTradeTicketSendCloseModel : AlipayObject
    {
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 停止发码原因
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 外部请求流水号
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 口碑商品发货单号
        /// </summary>
        [JsonPropertyName("send_order_no")]
        public string SendOrderNo { get; set; }

        /// <summary>
        /// 凭证发放token
        /// </summary>
        [JsonPropertyName("send_token")]
        public string SendToken { get; set; }
    }
}
