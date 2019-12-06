using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosCategorySaveModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosCategorySaveModel : AlipayObject
    {
        /// <summary>
        /// 排序菜类列表
        /// </summary>
        [JsonPropertyName("category_entity_list")]
        public List<DishCategoryEntity> CategoryEntityList { get; set; }
    }
}
