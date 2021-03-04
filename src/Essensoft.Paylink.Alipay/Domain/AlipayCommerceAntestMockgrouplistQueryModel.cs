using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceAntestMockgrouplistQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceAntestMockgrouplistQueryModel : AlipayObject
    {
        /// <summary>
        /// appId
        /// </summary>
        [JsonPropertyName("app_code")]
        public string AppCode { get; set; }
    }
}
