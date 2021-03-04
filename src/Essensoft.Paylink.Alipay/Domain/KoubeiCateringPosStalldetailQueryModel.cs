using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosStalldetailQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosStalldetailQueryModel : AlipayObject
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
