using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceAntestAppversionQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceAntestAppversionQueryModel : AlipayObject
    {
        /// <summary>
        /// appId
        /// </summary>
        [JsonPropertyName("app_code")]
        public string AppCode { get; set; }
    }
}
