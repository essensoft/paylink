using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringPosCategoryQueryResponse.
    /// </summary>
    public class KoubeiCateringPosCategoryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 菜类信息
        /// </summary>
        [JsonPropertyName("dish_category_entity")]
        public DishCategoryEntity DishCategoryEntity { get; set; }
    }
}
