using Newtonsoft.Json;

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
        [JsonProperty("commodity_order_id")]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 商家订购服务选择的某一门店的ID，如果该订单为口碑服务市场发布的服务所产生的订单，则此字段必填
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
