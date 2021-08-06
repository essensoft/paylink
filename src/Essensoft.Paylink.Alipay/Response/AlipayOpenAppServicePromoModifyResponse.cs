using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAppServicePromoModifyResponse.
    /// </summary>
    public class AlipayOpenAppServicePromoModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 服务场景素材记录ID
        /// </summary>
        [JsonPropertyName("promo_record_id")]
        public string PromoRecordId { get; set; }
    }
}
