using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdDfesfDefBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityProdDfesfDefBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("ded")]
        public string Ded { get; set; }
    }
}
