using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishVirtualcategoryQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishVirtualcategoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 虚拟类目名称
        /// </summary>
        [JsonPropertyName("catetory_name")]
        public string CatetoryName { get; set; }

        /// <summary>
        /// 外部门店id，和shop_id二选一必填，当都传时，以shop_id为准
        /// </summary>
        [JsonPropertyName("out_shop_id")]
        public string OutShopId { get; set; }

        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
