using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayGongyiAddressTest Data Structure.
    /// </summary>
    public class AlipayGongyiAddressTest : AlipayObject
    {
        /// <summary>
        /// 航海走
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 中国
        /// </summary>
        [JsonPropertyName("contury")]
        public string Contury { get; set; }

        /// <summary>
        /// 街道
        /// </summary>
        [JsonPropertyName("street")]
        public string Street { get; set; }
    }
}
