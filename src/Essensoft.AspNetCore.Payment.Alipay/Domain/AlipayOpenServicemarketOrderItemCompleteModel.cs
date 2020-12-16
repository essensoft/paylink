using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketOrderItemCompleteModel Data Structure.
    /// </summary>
    public class AlipayOpenServicemarketOrderItemCompleteModel : AlipayObject
    {
        /// <summary>
        /// 订购服务插件订单号
        /// </summary>
        [JsonPropertyName("commodity_order_id")]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 商家订购服务选择的某一小程序的APPID，如果该订单为蚂蚁服务市场发布的小程序插件服务所产生的订单，则此字段必填
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 商家订购服务选择的某一门店的ID。若该订单： 为支付宝服务市场发布的服务所产生订单则该参数可选。 为口碑服务市场发布的服务所产生的订单，则此字段必填。口碑服务市场参见 http://fuwu.koubei.com/commodity/v2/merchandise/index.htm。
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
