using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
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
