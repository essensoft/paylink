using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiServindustryPromoIntelligentguideConsultModel Data Structure.
    /// </summary>
    public class KoubeiServindustryPromoIntelligentguideConsultModel : AlipayObject
    {
        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 口碑shopId
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }
    }
}
