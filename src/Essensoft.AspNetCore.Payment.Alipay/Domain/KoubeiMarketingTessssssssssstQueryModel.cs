using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingTessssssssssstQueryModel Data Structure.
    /// </summary>
    public class KoubeiMarketingTessssssssssstQueryModel : AlipayObject
    {
        /// <summary>
        /// tset
        /// </summary>
        [JsonPropertyName("age")]
        public long Age { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [JsonPropertyName("height")]
        public string Height { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [JsonPropertyName("object")]
        public SpiInputObject Object { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [JsonPropertyName("params")]
        public AccessParams Params { get; set; }

        /// <summary>
        /// test
        /// </summary>
        [JsonPropertyName("x_name")]
        public string XName { get; set; }
    }
}
