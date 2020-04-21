using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishCookDetailInfo Data Structure.
    /// </summary>
    public class KbdishCookDetailInfo : AlipayObject
    {
        /// <summary>
        /// 菜谱大类
        /// </summary>
        [JsonPropertyName("catetory_big_id")]
        public string CatetoryBigId { get; set; }

        /// <summary>
        /// 菜谱小类
        /// </summary>
        [JsonPropertyName("catetory_small_id")]
        public string CatetorySmallId { get; set; }

        /// <summary>
        /// 菜谱id
        /// </summary>
        [JsonPropertyName("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [JsonPropertyName("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 打标
        /// </summary>
        [JsonPropertyName("flag")]
        public string Flag { get; set; }

        /// <summary>
        /// 价格明细
        /// </summary>
        [JsonPropertyName("kb_cook_sku_price_list")]
        public List<KbdishCookPriceInfo> KbCookSkuPriceList { get; set; }

        /// <summary>
        /// 排序值
        /// </summary>
        [JsonPropertyName("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
