using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneProductAgreementCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneProductAgreementCancelModel : AlipayObject
    {
        /// <summary>
        /// 签订协议商户支付宝用户ID
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [JsonProperty("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 产品协议号
        /// </summary>
        [JsonProperty("product_sign_no")]
        public string ProductSignNo { get; set; }
    }
}
