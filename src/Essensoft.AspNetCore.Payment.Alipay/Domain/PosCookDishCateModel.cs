using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PosCookDishCateModel Data Structure.
    /// </summary>
    public class PosCookDishCateModel : AlipayObject
    {
        /// <summary>
        /// 菜类下的菜品数量
        /// </summary>
        [JsonPropertyName("cate_dish_num")]
        public long CateDishNum { get; set; }

        /// <summary>
        /// 菜类ID
        /// </summary>
        [JsonPropertyName("cate_id")]
        public string CateId { get; set; }

        /// <summary>
        /// 菜类的名字
        /// </summary>
        [JsonPropertyName("cate_name")]
        public string CateName { get; set; }

        /// <summary>
        /// 菜类的排序号
        /// </summary>
        [JsonPropertyName("cate_sort")]
        public long CateSort { get; set; }
    }
}
