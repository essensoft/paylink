using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringDishEstimateQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringDishEstimateQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部门店id，外部门店id和口碑门店id，必须二选一必填，当都传入时，以口碑门店id为准
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
