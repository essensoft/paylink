using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntpaasTokenThirdTrustLoginModel Data Structure.
    /// </summary>
    public class AlipayUserAntpaasTokenThirdTrustLoginModel : AlipayObject
    {
        /// <summary>
        /// 登录的目标业务，目前已经分配的有autoins，代表车险业务
        /// </summary>
        [JsonProperty("login_target")]
        public string LoginTarget { get; set; }
    }
}
