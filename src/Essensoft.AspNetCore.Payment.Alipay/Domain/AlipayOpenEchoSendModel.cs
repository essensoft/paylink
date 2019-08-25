using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenEchoSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenEchoSendModel : AlipayObject
    {
        /// <summary>
        /// city
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
