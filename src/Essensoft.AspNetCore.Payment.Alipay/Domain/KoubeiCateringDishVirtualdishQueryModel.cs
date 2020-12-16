using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishVirtualdishQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishVirtualdishQueryModel : AlipayObject
    {
        /// <summary>
        /// 虚拟类目id，如果传入，也会做为查询条件
        /// </summary>
        [JsonPropertyName("catetory_id")]
        public string CatetoryId { get; set; }

        /// <summary>
        /// 口碑侧门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
