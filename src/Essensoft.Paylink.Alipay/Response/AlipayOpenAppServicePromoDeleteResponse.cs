using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppServicePromoDeleteResponse.
    /// </summary>
    public class AlipayOpenAppServicePromoDeleteResponse : AlipayResponse
    {
        /// <summary>
        /// 服务场景素材记录ID
        /// </summary>
        [JsonPropertyName("promo_record_id")]
        public string PromoRecordId { get; set; }
    }
}
