using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AliTrustScore Data Structure.
    /// </summary>
    [Serializable]
    public class AliTrustScore : AlipayObject
    {
        /// <summary>
        /// 芝麻分
        /// </summary>
        [JsonProperty("score")]
        public long Score { get; set; }
    }
}
