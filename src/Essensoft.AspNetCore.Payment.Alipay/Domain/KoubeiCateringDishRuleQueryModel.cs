using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishRuleQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishRuleQueryModel : AlipayObject
    {
        /// <summary>
        /// 规则的类型，枚举值如下：  DEFAULT_IN_CARTS  // "开台默认菜";  NON_WHOLE_ORDER_DISCOUNT", //"不参与整单优惠的菜";  MUST_IN_ORDER // "下单必点菜";
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 当查询规则类型biz_type为DEFAULT_IN_CARTS，即开台默认菜的时候，本项必填。
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }
    }
}
