using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ItemConsultInfo Data Structure.
    /// </summary>
    public class ItemConsultInfo : AlipayObject
    {
        /// <summary>
        /// 商品id
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品优惠金额，单位为元
        /// </summary>
        [JsonPropertyName("promo_amount")]
        public string PromoAmount { get; set; }

        /// <summary>
        /// 商品优惠数量
        /// </summary>
        [JsonPropertyName("promo_count")]
        public string PromoCount { get; set; }
    }
}
