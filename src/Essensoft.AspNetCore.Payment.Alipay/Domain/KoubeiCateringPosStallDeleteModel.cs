using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosStallDeleteModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosStallDeleteModel : AlipayObject
    {
        /// <summary>
        /// 门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 档口id
        /// </summary>
        [JsonPropertyName("stall_id")]
        public string StallId { get; set; }
    }
}
