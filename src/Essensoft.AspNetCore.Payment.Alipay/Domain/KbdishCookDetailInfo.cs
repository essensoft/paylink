using Newtonsoft.Json;
using System.Collections.Generic;

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
        [JsonProperty("catetory_big_id")]
        public string CatetoryBigId { get; set; }

        /// <summary>
        /// 菜谱小类
        /// </summary>
        [JsonProperty("catetory_small_id")]
        public string CatetorySmallId { get; set; }

        /// <summary>
        /// 菜谱id
        /// </summary>
        [JsonProperty("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜品id
        /// </summary>
        [JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 打标
        /// </summary>
        [JsonProperty("flag")]
        public string Flag { get; set; }

        /// <summary>
        /// 价格明细
        /// </summary>
        [JsonProperty("kb_cook_sku_price_list")]
        public List<KbdishCookPriceInfo> KbCookSkuPriceList { get; set; }

        /// <summary>
        /// 排序值
        /// </summary>
        [JsonProperty("sort")]
        public string Sort { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
