using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertDeliveryDiscountQueryModel Data Structure.
    /// </summary>
    public class KoubeiAdvertDeliveryDiscountQueryModel : AlipayObject
    {
        /// <summary>
        /// 优惠id，调用优惠查询接口时，需要提供“优惠id”
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }
    }
}
