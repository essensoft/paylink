using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishRuleInfo Data Structure.
    /// </summary>
    public class KbdishRuleInfo : AlipayObject
    {
        /// <summary>
        /// 规则的类型，枚举值如下：  DEFAULT_IN_CARTS  // "开台默认菜";  NON_WHOLE_ORDER_DISCOUNT", //"不参与整单优惠的菜";  MUST_IN_ORDER // "下单必点菜";
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 开台菜规则模型，在biz_type为开台菜的时候，此项必填。
        /// </summary>
        [JsonPropertyName("default_in_cart_info")]
        public DefaultInCartInfo DefaultInCartInfo { get; set; }

        /// <summary>
        /// 菜品id，必填
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 扩展信息，存放JSON
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 表示规则适用的范围，枚举值如下：    PARTNER_ID// 商户；    SHOP   //门店；    CATEGORY //菜谱。
        /// </summary>
        [JsonPropertyName("rule_type")]
        public string RuleType { get; set; }

        /// <summary>
        /// 根据rule_type的不同，此处填入规则适用的merchant_id,或者shop_id,或者cook_id的集合
        /// </summary>
        [JsonPropertyName("rule_value")]
        public List<string> RuleValue { get; set; }

        /// <summary>
        /// 当biz_type为DEFAULT_IN_CARTS，即开台默认菜的时候，本项必填。
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// open:启用;stop:停用。
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
