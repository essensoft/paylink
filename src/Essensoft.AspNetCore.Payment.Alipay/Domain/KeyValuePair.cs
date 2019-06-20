using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KeyValuePair Data Structure.
    /// </summary>
    [Serializable]
    public class KeyValuePair : AlipayObject
    {
        /// <summary>
        /// key
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// value
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
