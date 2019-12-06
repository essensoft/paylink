using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneProductAgreementCancelModel Data Structure.
    /// </summary>
    public class AlipayInsSceneProductAgreementCancelModel : AlipayObject
    {
        /// <summary>
        /// 签订协议商户支付宝用户ID
        /// </summary>
        [JsonPropertyName("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 产品协议号
        /// </summary>
        [JsonPropertyName("product_sign_no")]
        public string ProductSignNo { get; set; }
    }
}
