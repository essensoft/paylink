using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppServicePromotemplateQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppServicePromotemplateQueryModel : AlipayObject
    {
        /// <summary>
        /// 展台ID
        /// </summary>
        [JsonPropertyName("promo_booth_id")]
        public string PromoBoothId { get; set; }

        /// <summary>
        /// 展台版本
        /// </summary>
        [JsonPropertyName("promo_booth_version")]
        public long PromoBoothVersion { get; set; }
    }
}
