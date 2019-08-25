using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMerchantKbcloudSubuserlogoutEffectModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMerchantKbcloudSubuserlogoutEffectModel : AlipayObject
    {
        /// <summary>
        /// 登录的sessionId
        /// </summary>
        [JsonProperty("session_id")]
        public string SessionId { get; set; }
    }
}
