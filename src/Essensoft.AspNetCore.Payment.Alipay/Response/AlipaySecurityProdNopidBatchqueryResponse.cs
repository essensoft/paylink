using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdNopidBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityProdNopidBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 111
        /// </summary>
        [JsonPropertyName("rthreemcc")]
        public string Rthreemcc { get; set; }
    }
}
