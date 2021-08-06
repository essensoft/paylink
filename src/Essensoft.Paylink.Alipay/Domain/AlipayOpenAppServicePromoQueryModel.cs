using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppServicePromoQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppServicePromoQueryModel : AlipayObject
    {
        /// <summary>
        /// 服务场景素材记录ID
        /// </summary>
        [JsonPropertyName("promo_record_id")]
        public string PromoRecordId { get; set; }
    }
}
