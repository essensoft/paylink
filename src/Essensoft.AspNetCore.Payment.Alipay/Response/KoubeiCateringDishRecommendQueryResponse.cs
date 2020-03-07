using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishRecommendQueryResponse.
    /// </summary>
    public class KoubeiCateringDishRecommendQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 推荐菜品列表
        /// </summary>
        [JsonPropertyName("dish_list")]
        public List<DishRecommend> DishList { get; set; }
    }
}
