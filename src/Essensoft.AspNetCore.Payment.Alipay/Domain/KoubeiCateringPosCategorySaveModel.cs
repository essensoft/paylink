using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosCategorySaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosCategorySaveModel : AlipayObject
    {
        /// <summary>
        /// 排序菜类列表
        /// </summary>
        [JsonProperty("category_entity_list")]
        public List<DishCategoryEntity> CategoryEntityList { get; set; }
    }
}
