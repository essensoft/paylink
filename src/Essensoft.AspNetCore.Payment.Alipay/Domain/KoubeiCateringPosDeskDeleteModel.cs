using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDeskDeleteModel Data Structure.
    /// </summary>
    public class KoubeiCateringPosDeskDeleteModel : AlipayObject
    {
        /// <summary>
        /// 桌位Id
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 门店Id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
