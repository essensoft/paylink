using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntpaasTokenThirdTrustLoginModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAntpaasTokenThirdTrustLoginModel : AlipayObject
    {
        /// <summary>
        /// 登录的目标业务，目前已经分配的有autoins，代表车险业务
        /// </summary>
        [JsonProperty("login_target")]
        public string LoginTarget { get; set; }
    }
}
