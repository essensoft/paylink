using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserPeerpayprodAgreementQueryModel Data Structure.
    /// </summary>
    public class AlipayUserPeerpayprodAgreementQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝userId，用于亲情号被开通人
        /// </summary>
        [JsonPropertyName("alipay_related_uid")]
        public string AlipayRelatedUid { get; set; }

        /// <summary>
        /// 支付宝userId，用于亲情号开通人
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
