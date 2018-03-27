using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicXwbtestabcdBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicXwbtestabcdBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 1111112141414
        /// </summary>
        [JsonProperty("s")]
        public string S { get; set; }
    }
}
