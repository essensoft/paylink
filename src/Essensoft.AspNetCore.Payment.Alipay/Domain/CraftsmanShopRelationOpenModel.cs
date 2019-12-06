using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CraftsmanShopRelationOpenModel Data Structure.
    /// </summary>
    public class CraftsmanShopRelationOpenModel : AlipayObject
    {
        /// <summary>
        /// 推荐权重。整数。小于等于0表示不在口碑店铺页展示 大于0表示在口碑店铺页展示， 值越大，排序越靠前。
        /// </summary>
        [JsonPropertyName("recommend_weight")]
        public long RecommendWeight { get; set; }

        /// <summary>
        /// 口碑门店ID，可通过门店摘要信息批量查询接口 alipay.offline.market.shop.summary.batchquery获取。
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
