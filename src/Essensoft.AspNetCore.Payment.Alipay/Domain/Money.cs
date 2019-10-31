using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Money Data Structure.
    /// </summary>
    [Serializable]
    public class Money : AlipayObject
    {
        /// <summary>
        /// 3-letter currency code, refer to ISO 4217 Standard currency alphabetic code
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// amount value
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
