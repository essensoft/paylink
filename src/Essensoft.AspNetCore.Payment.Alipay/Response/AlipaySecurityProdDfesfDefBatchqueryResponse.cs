using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipaySecurityProdDfesfDefBatchqueryResponse.
    /// </summary>
    public class AlipaySecurityProdDfesfDefBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("ded")]
        public string Ded { get; set; }
    }
}
