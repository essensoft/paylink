using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GavintestNewLeveaOne Data Structure.
    /// </summary>
    [Serializable]
    public class GavintestNewLeveaOne : AlipayObject
    {
        /// <summary>
        /// 2
        /// </summary>
        [JsonProperty("boolen")]
        public bool Boolen { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [JsonProperty("ces")]
        public List<long> Ces { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        [JsonProperty("des")]
        public string Des { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("str")]
        public List<string> Str { get; set; }
    }
}
