using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicXwbtestabcdBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicXwbtestabcdBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1111
        /// </summary>
        [JsonPropertyName("b")]
        public string B { get; set; }
    }
}
