using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketYcstestQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenServicemarketYcstestQueryModel : AlipayObject
    {
        /// <summary>
        /// aaaa
        /// </summary>
        [JsonPropertyName("in_1")]
        public string In1 { get; set; }

        /// <summary>
        /// 222
        /// </summary>
        [JsonPropertyName("in_2")]
        public bool In2 { get; set; }

        /// <summary>
        /// 333
        /// </summary>
        [JsonPropertyName("in_3")]
        public string In3 { get; set; }

        /// <summary>
        /// 444
        /// </summary>
        [JsonPropertyName("in_4")]
        public long In4 { get; set; }

        /// <summary>
        /// 55
        /// </summary>
        [JsonPropertyName("in_5")]
        public string In5 { get; set; }

        /// <summary>
        /// 66666
        /// </summary>
        [JsonPropertyName("in_6")]
        public XwbTestData In6 { get; set; }
    }
}
