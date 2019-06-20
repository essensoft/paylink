using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketYcstestQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketYcstestQueryModel : AlipayObject
    {
        /// <summary>
        /// aaaa
        /// </summary>
        [JsonProperty("in_1")]
        public string In1 { get; set; }

        /// <summary>
        /// 222
        /// </summary>
        [JsonProperty("in_2")]
        public bool In2 { get; set; }

        /// <summary>
        /// 333
        /// </summary>
        [JsonProperty("in_3")]
        public string In3 { get; set; }

        /// <summary>
        /// 444
        /// </summary>
        [JsonProperty("in_4")]
        public long In4 { get; set; }

        /// <summary>
        /// 55
        /// </summary>
        [JsonProperty("in_5")]
        public string In5 { get; set; }

        /// <summary>
        /// 66666
        /// </summary>
        [JsonProperty("in_6")]
        public XwbTestData In6 { get; set; }
    }
}
