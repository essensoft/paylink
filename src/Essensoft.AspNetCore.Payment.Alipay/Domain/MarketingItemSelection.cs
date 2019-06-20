using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MarketingItemSelection Data Structure.
    /// </summary>
    [Serializable]
    public class MarketingItemSelection : AlipayObject
    {
        /// <summary>
        /// 营销项目ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }
    }
}
