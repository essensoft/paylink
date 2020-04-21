using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketCommodityShopOfflineModel Data Structure.
    /// </summary>
    public class AlipayOpenServicemarketCommodityShopOfflineModel : AlipayObject
    {
        /// <summary>
        /// 服务商户ID
        /// </summary>
        [JsonPropertyName("commodity_id")]
        public string CommodityId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
