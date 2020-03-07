using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MakePriceResult Data Structure.
    /// </summary>
    public class MakePriceResult : AlipayObject
    {
        /// <summary>
        /// 定价对象原价
        /// </summary>
        [JsonPropertyName("base_price_cent")]
        public string BasePriceCent { get; set; }

        /// <summary>
        /// 定价对象类型
        /// </summary>
        [JsonPropertyName("product_type")]
        public string ProductType { get; set; }

        /// <summary>
        /// 定价对象推荐价格
        /// </summary>
        [JsonPropertyName("promo_price")]
        public string PromoPrice { get; set; }
    }
}
