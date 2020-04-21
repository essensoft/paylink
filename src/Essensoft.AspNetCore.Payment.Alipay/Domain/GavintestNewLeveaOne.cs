using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// GavintestNewLeveaOne Data Structure.
    /// </summary>
    public class GavintestNewLeveaOne : AlipayObject
    {
        /// <summary>
        /// 2
        /// </summary>
        [JsonPropertyName("boolen")]
        public bool Boolen { get; set; }

        /// <summary>
        /// 21
        /// </summary>
        [JsonPropertyName("ces")]
        public List<long> Ces { get; set; }

        /// <summary>
        /// 12
        /// </summary>
        [JsonPropertyName("des")]
        public string Des { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("str")]
        public List<string> Str { get; set; }
    }
}
