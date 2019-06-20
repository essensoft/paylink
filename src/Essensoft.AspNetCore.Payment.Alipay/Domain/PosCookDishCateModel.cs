using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosCookDishCateModel Data Structure.
    /// </summary>
    [Serializable]
    public class PosCookDishCateModel : AlipayObject
    {
        /// <summary>
        /// 菜类下的菜品数量
        /// </summary>
        [JsonProperty("cate_dish_num")]
        public long CateDishNum { get; set; }

        /// <summary>
        /// 菜类ID
        /// </summary>
        [JsonProperty("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 菜类的名字
        /// </summary>
        [JsonProperty("cate_name")]
        public string CateName { get; set; }

        /// <summary>
        /// 菜类的排序号
        /// </summary>
        [JsonProperty("cate_sort")]
        public long CateSort { get; set; }
    }
}
