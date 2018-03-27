using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicXwbtestabcdBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicXwbtestabcdBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 1111
        /// </summary>
        [JsonProperty("b")]
        public string B { get; set; }
    }
}
