using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingTessssssssssstQueryResponse.
    /// </summary>
    public class KoubeiMarketingTessssssssssstQueryResponse : AlipayResponse
    {
        /// <summary>
        /// a
        /// </summary>
        [JsonPropertyName("a")]
        public string A { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [JsonPropertyName("category")]
        public Category Category { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [JsonPropertyName("output")]
        public SpiOutputObject Output { get; set; }
    }
}
