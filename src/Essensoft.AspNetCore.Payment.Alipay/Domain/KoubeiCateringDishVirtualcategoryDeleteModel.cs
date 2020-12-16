using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishVirtualcategoryDeleteModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishVirtualcategoryDeleteModel : AlipayObject
    {
        /// <summary>
        /// 如果需要删除某一个类目时传入
        /// </summary>
        [JsonPropertyName("catetory_name")]
        public string CatetoryName { get; set; }

        /// <summary>
        /// 外部门店id，与口碑门店id二选一必填，如果都填，以口碑门店id为准
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
