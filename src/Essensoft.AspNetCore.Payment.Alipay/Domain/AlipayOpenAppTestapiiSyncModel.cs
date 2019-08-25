using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppTestapiiSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppTestapiiSyncModel : AlipayObject
    {
        /// <summary>
        /// v
        /// </summary>
        [JsonProperty("in_1")]
        public string In1 { get; set; }

        /// <summary>
        /// b
        /// </summary>
        [JsonProperty("in_2")]
        public string In2 { get; set; }
    }
}
