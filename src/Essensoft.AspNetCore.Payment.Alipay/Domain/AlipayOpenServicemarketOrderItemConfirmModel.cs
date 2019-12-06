using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketOrderItemConfirmModel Data Structure.
    /// </summary>
    public class AlipayOpenServicemarketOrderItemConfirmModel : AlipayObject
    {
        /// <summary>
        /// 商品订单ID
        /// </summary>
        [JsonPropertyName("commodity_order_id")]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 商家订购服务选择的某一小程序的APPID，如果该订单为蚂蚁服务市场发布的小程序插件服务所产生的订单，则此字段必填
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 商家订购服务选择的某一门店的ID，如果该订单为口碑服务市场发布的服务所产生的订单，则此字段必填
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
