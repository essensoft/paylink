using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserPeerpayprodAgreementSignModel Data Structure.
    /// </summary>
    public class AlipayUserPeerpayprodAgreementSignModel : AlipayObject
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
        /// 页面渲染默认签约的额度，单位是元，示例值是10000元
        /// </summary>
        [JsonPropertyName("quota")]
        public long Quota { get; set; }

        /// <summary>
        /// 开通人与被开通人的关系标签；alipay_user_id,alipay_related_id的关系； 如果传空默认为"其他亲友" 其他示例值: "爸爸","妈妈","儿子","女儿","其他亲友","公公","婆婆","老婆","老公","岳父","岳母"
        /// </summary>
        [JsonPropertyName("relation_name")]
        public string RelationName { get; set; }

        /// <summary>
        /// 签约来源
        /// </summary>
        [JsonPropertyName("request_from")]
        public string RequestFrom { get; set; }
    }
}
