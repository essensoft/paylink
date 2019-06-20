using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbIsvMaCode Data Structure.
    /// </summary>
    [Serializable]
    public class KbIsvMaCode : AlipayObject
    {
        /// <summary>
        /// 凭证码值
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// 码的可核销份数
        /// </summary>
        [JsonProperty("num")]
        public string Num { get; set; }
    }
}
