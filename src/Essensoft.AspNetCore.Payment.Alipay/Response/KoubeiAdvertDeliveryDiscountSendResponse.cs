using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiAdvertDeliveryDiscountSendResponse.
    /// </summary>
    public class KoubeiAdvertDeliveryDiscountSendResponse : AlipayResponse
    {
        /// <summary>
        /// 权益详细信息：  partnerId：商户ID（用于打开手机钱包券详情）
        /// </summary>
        [JsonPropertyName("benefit_detail")]
        public string BenefitDetail { get; set; }

        /// <summary>
        /// 广告id对应的权益id
        /// </summary>
        [JsonPropertyName("benefit_id")]
        public string BenefitId { get; set; }
    }
}
