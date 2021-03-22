using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// DeviceOrderStatus Data Structure.
    /// </summary>
    public class DeviceOrderStatus : AlipayObject
    {
        /// <summary>
        /// 设备订单状态 已下发 SYNC:20 已打印 PRINT:30
        /// </summary>
        [JsonPropertyName("device_order_status")]
        public long DeviceOrderStatus_ { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonPropertyName("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 到店订单类型:SHOP_SERVICE 到家订单类型:HOME_SERVICE
        /// </summary>
        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }
    }
}
