using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Pair Data Structure.
    /// </summary>
    [Serializable]
    public class Pair : AlipayObject
    {
        /// <summary>
        /// KEY
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
