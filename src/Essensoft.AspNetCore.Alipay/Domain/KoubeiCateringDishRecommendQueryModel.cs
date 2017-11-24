using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishRecommendQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishRecommendQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户已点的主菜品ID，传入时作为推荐菜品参考
        /// </summary>
        [JsonProperty("dish_id")]
        public string DishId { get; set; }

        /// <summary>
        /// 点餐门店所属的商家PID
        /// </summary>
        [JsonProperty("merchent_pid")]
        public string MerchentPid { get; set; }

        /// <summary>
        /// 点餐的门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
