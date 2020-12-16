using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishCookDetailSimplifyInfo Data Structure.
    /// </summary>
    public class KbdishCookDetailSimplifyInfo : AlipayObject
    {
        /// <summary>
        /// 外部菜品id
        /// </summary>
        [JsonPropertyName("out_dish_id")]
        public string OutDishId { get; set; }

        /// <summary>
        /// 外部skuid
        /// </summary>
        [JsonPropertyName("out_sku_id")]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 售卖价格
        /// </summary>
        [JsonPropertyName("sell_price")]
        public string SellPrice { get; set; }

        /// <summary>
        /// 排序值
        /// </summary>
        [JsonPropertyName("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// 菜品在菜谱中的售卖时间，同一个out_dish_id都指定的情况下 以第一个为准
        /// </summary>
        [JsonPropertyName("time_ranges")]
        public List<string> TimeRanges { get; set; }
    }
}
