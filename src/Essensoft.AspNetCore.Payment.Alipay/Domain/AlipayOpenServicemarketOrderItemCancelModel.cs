using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketOrderItemCancelModel Data Structure.
    /// </summary>
    public class AlipayOpenServicemarketOrderItemCancelModel : AlipayObject
    {
        /// <summary>
        /// 当前门店区域不支持实施
        /// </summary>
        [JsonProperty("cancel_reason")]
        public string CancelReason { get; set; }

        /// <summary>
        /// 订购服务订单ID
        /// </summary>
        [JsonProperty("commodity_order_id")]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 订购服务门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
