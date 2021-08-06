using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// DeviceExtParams Data Structure.
    /// </summary>
    public class DeviceExtParams : AlipayObject
    {
        /// <summary>
        /// 商户编号，由ISV定义，需要保证在ISV下唯一
        /// </summary>
        [JsonPropertyName("external_id")]
        public string ExternalId { get; set; }

        /// <summary>
        /// 外部门店id
        /// </summary>
        [JsonPropertyName("external_shop_id")]
        public string ExternalShopId { get; set; }

        /// <summary>
        /// 支付类型 云支付服务商：ALIPAY_CLOUD 生态服务商：SPI
        /// </summary>
        [JsonPropertyName("payment_type")]
        public string PaymentType { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        [JsonPropertyName("shop_name")]
        public string ShopName { get; set; }

        /// <summary>
        /// 进件服务商pid
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// isv应用id，绑定流程不消费，订单中心消费。
        /// </summary>
        [JsonPropertyName("spi_app_id")]
        public string SpiAppId { get; set; }

        /// <summary>
        /// sv内部唯一标识商户、商户门店等字段信息
        /// </summary>
        [JsonPropertyName("terminal_bind_info")]
        public string TerminalBindInfo { get; set; }
    }
}
