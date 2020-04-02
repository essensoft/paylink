using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishVirtualCategoryInfo Data Structure.
    /// </summary>
    public class KbdishVirtualCategoryInfo : AlipayObject
    {
        /// <summary>
        /// 虚拟类目id
        /// </summary>
        [JsonPropertyName("catetory_id")]
        public string CatetoryId { get; set; }

        /// <summary>
        /// 口碑菜品列表
        /// </summary>
        [JsonPropertyName("dish_list")]
        public List<KbVirtualShopCategoryDishInfo> DishList { get; set; }
    }
}
