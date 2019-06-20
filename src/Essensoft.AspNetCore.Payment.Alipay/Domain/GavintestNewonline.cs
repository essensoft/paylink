using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GavintestNewonline Data Structure.
    /// </summary>
    [Serializable]
    public class GavintestNewonline : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("dem")]
        public List<string> Dem { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [JsonProperty("string")]
        public GavintestNewLeveaOne String { get; set; }
    }
}
