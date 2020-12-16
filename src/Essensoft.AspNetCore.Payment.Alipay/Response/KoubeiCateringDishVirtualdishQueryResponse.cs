using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiCateringDishVirtualdishQueryResponse.
    /// </summary>
    public class KoubeiCateringDishVirtualdishQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 门店下虚拟类目下的菜品id列表
        /// </summary>
        [JsonPropertyName("dish_list")]
        public List<KbdishVirtualDishInfo> DishList { get; set; }

        /// <summary>
        /// 口碑侧门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
