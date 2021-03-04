using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceAntestCaselistQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceAntestCaselistQueryModel : AlipayObject
    {
        /// <summary>
        /// appId
        /// </summary>
        [JsonPropertyName("app_code")]
        public string AppCode { get; set; }
    }
}
