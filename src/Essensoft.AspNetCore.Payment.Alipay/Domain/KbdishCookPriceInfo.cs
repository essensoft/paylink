using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishCookPriceInfo Data Structure.
    /// </summary>
    public class KbdishCookPriceInfo : AlipayObject
    {
        /// <summary>
        /// 菜单id
        /// </summary>
        [JsonPropertyName("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 会员价，目前已废弃
        /// </summary>
        [JsonPropertyName("member_price")]
        public string MemberPrice { get; set; }

        /// <summary>
        /// 售卖价格
        /// </summary>
        [JsonPropertyName("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// skuid
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }
    }
}
