using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketCommodityShopOnlineModel Data Structure.
    /// </summary>
    public class AlipayOpenServicemarketCommodityShopOnlineModel : AlipayObject
    {
        /// <summary>
        /// 服务插件ID
        /// </summary>
        [JsonProperty("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
