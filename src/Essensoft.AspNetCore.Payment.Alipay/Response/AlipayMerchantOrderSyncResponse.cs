using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantOrderSyncResponse.
    /// </summary>
    public class AlipayMerchantOrderSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单状态
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 同步订单记录id
        /// </summary>
        [JsonPropertyName("record_id")]
        public string RecordId { get; set; }
    }
}
