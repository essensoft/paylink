using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserSafeboxConditionQueryResponse.
    /// </summary>
    public class AlipayUserSafeboxConditionQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 产品是否紧急下线状态。true：紧急下线，false：未紧急下线。
        /// </summary>
        [JsonPropertyName("emergency_offline")]
        public bool EmergencyOffline { get; set; }

        /// <summary>
        /// 是否用户已经签约。已经签约：true，未签约：false。
        /// </summary>
        [JsonPropertyName("has_agreement")]
        public bool HasAgreement { get; set; }
    }
}
