using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAuthSecondpartyTokenVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAuthSecondpartyTokenVerifyModel : AlipayObject
    {
        /// <summary>
        /// 二方登录token
        /// </summary>
        [JsonProperty("second_party_token")]
        public string SecondPartyToken { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
