using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishCategorySimplifyInfo Data Structure.
    /// </summary>
    public class KbdishCategorySimplifyInfo : AlipayObject
    {
        /// <summary>
        /// 菜谱类目名称
        /// </summary>
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 类目下菜品列表
        /// </summary>
        [JsonPropertyName("dish_list")]
        public List<KbdishCookDetailSimplifyInfo> DishList { get; set; }

        /// <summary>
        /// 类目是否隐藏，默认不隐藏
        /// </summary>
        [JsonPropertyName("hidden")]
        public bool Hidden { get; set; }

        /// <summary>
        /// 类目标签图片id
        /// </summary>
        [JsonPropertyName("label_image")]
        public string LabelImage { get; set; }

        /// <summary>
        /// 类目排序
        /// </summary>
        [JsonPropertyName("sort")]
        public string Sort { get; set; }
    }
}
