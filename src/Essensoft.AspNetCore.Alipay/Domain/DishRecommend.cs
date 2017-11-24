using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// DishRecommend Data Structure.
    /// </summary>
    public class DishRecommend : AlipayObject
    {
        /// <summary>
        /// 购买可能性/商品热度得分
        /// </summary>
        [JsonProperty("buy_posibility")]
        public string BuyPosibility { get; set; }

        /// <summary>
        /// 菜品ID
        /// </summary>
        [JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 菜品名称
        /// </summary>
        [JsonProperty("dish_name")]
        public string DishName { get; set; }
    }
}
