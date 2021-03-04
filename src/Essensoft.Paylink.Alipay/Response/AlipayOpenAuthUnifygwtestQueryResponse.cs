using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAuthUnifygwtestQueryResponse.
    /// </summary>
    public class AlipayOpenAuthUnifygwtestQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("des")]
        public string Des { get; set; }
    }
}
