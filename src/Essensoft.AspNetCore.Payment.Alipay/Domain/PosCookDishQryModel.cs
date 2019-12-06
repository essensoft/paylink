using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosCookDishQryModel Data Structure.
    /// </summary>
    public class PosCookDishQryModel : AlipayObject
    {
        /// <summary>
        /// 菜类的list，返回的是售卖类别的ID
        /// </summary>
        [JsonPropertyName("cate_list")]
        public List<PosCookDishCateModel> CateList { get; set; }

        /// <summary>
        /// 菜品详情列表
        /// </summary>
        [JsonPropertyName("dish_list")]
        public List<PosCookDishQryDetailModel> DishList { get; set; }
    }
}
