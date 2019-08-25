using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotAdvertiserAdCancelModel : AlipayObject
    {
        /// <summary>
        /// 投放计划id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
