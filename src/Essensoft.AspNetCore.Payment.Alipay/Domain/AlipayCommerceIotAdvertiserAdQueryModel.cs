using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotAdvertiserAdQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotAdvertiserAdQueryModel : AlipayObject
    {
        /// <summary>
        /// 投放计划id
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
