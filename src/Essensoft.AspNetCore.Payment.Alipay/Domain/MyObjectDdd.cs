using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MyObjectDdd Data Structure.
    /// </summary>
    [Serializable]
    public class MyObjectDdd : AlipayObject
    {
        /// <summary>
        /// xx
        /// </summary>
        [JsonProperty("item")]
        public string Item { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("param")]
        public string Param { get; set; }
    }
}
