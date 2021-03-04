using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDeskQueryModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosDeskQueryModel : AlipayObject
    {
        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
