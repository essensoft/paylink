using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserProfileDetail Data Structure.
    /// </summary>
    [Serializable]
    public class UserProfileDetail : AlipayObject
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户发行主体;  ALIPAY:支付宝,TAOBAO:淘宝,MERCHANT:商户(星巴克)
        /// </summary>
        [JsonProperty("user_issuer")]
        public string UserIssuer { get; set; }
    }
}
