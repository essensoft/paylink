using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMatchuserFollowQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicMatchuserFollowQueryModel : AlipayObject
    {
        /// <summary>
        /// 身份证号码
        /// </summary>
        [JsonProperty("identity_card")]
        public string IdentityCard { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        [JsonProperty("mobile_no")]
        public string MobileNo { get; set; }

        /// <summary>
        /// 支付宝用户id，2088开头的16位长度字符串
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
