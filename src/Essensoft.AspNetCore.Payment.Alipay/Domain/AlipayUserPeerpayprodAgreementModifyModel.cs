using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserPeerpayprodAgreementModifyModel Data Structure.
    /// </summary>
    public class AlipayUserPeerpayprodAgreementModifyModel : AlipayObject
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

        /// <summary>
        /// 页面渲染默认修改的额度，单位是元，示例值是10000元
        /// </summary>
        [JsonPropertyName("quota")]
        public string Quota { get; set; }

        /// <summary>
        /// 签约来源
        /// </summary>
        [JsonPropertyName("request_from")]
        public string RequestFrom { get; set; }
    }
}
