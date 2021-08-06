using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppServicePromoApplyResponse.
    /// </summary>
    public class AlipayOpenAppServicePromoApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 服务场景素材记录ID
        /// </summary>
        [JsonPropertyName("promo_record_id")]
        public string PromoRecordId { get; set; }
    }
}
