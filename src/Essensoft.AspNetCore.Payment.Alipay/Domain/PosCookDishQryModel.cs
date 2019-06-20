using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosCookDishQryModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosCookDishQryModel : AlipayObject
    {
        /// <summary>
        /// 菜类的list，返回的是售卖类别的ID
        /// </summary>
        [JsonProperty("cate_list")]
        public List<PosCookDishCateModel> CateList { get; set; }

        /// <summary>
        /// 菜品详情列表
        /// </summary>
        [JsonProperty("dish_list")]
        public List<PosCookDishQryDetailModel> DishList { get; set; }
    }
}
