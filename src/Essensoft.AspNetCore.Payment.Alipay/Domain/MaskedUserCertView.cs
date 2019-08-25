using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MaskedUserCertView Data Structure.
    /// </summary>
    [Serializable]
    public class MaskedUserCertView : AlipayObject
    {
        /// <summary>
        /// 是否通过实名认证， 是 - T； 否 - F
        /// </summary>
        [JsonProperty("is_certified")]
        public string IsCertified { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 脱敏后的姓名
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
