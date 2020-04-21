using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandTradeorderEventSendResponse.
    /// </summary>
    public class AntMerchantExpandTradeorderEventSendResponse : AlipayResponse
    {
        /// <summary>
        /// 物流单状态：WAIT_PAY(待支付)、PAID(已支付)、WAIT_PAY_TIMEOUT(超时未支付)、COURIER_CONFIRMED(快递员已接单)、COURIER_ARRIVED_SEND(快递员已到达寄送点)、GOODS_PICKED(已取件)、GOODS_DELIVERED(已送达)、FINISHED(已完结)
        /// </summary>
        [JsonPropertyName("logistics_status")]
        public string LogisticsStatus { get; set; }

        /// <summary>
        /// 订单状态：PAID(已支付)、CANCEL_CLOSED(取消关闭)、SUCCESS_FINISHED(成功完结)、TIMEOUT_CLOSED(超时关闭)
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }
    }
}
