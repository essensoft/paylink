using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDeskareaQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosDeskareaQueryModel : AlipayObject
    {
        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
