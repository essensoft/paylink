using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppEbppConfirmpayurlTestQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppEbppConfirmpayurlTestQueryModel : AlipayObject
    {
        /// <summary>
        /// ss
        /// </summary>
        [JsonPropertyName("tess")]
        public string Tess { get; set; }
    }
}
